using AutomatizacionPruebasElectricas.Classes;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AutomatizacionPruebasElectricas.Views
{
	public partial class Reportes : Form
	{

		public Reportes()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{

		}

		private async void Reportes_Load(object sender, EventArgs e)
		{
			ClsProductos p = new ClsProductos();

			DataTable productos = await p.GetProductos("");

			comboBox1.DataSource = productos;

			comboBox1.DisplayMember = "Descripcion";
			comboBox1.ValueMember = "ID";
		}

		private async void BtnShowReport_Click(object sender, EventArgs e)
		{
			ClsReportes r = new ClsReportes();
			DataTable result;
			switch (comboBox2.SelectedIndex)
			{
				case 0:
					result = await r.ReporteDeEstadisticasPromedioDeResistenciaDeProducto(comboBox1.SelectedValue.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
					await GenerarReporteConGrafica(result, "resistencias.pdf", "resistencias");
					Process.Start("resistencias.pdf");
					break;

				case 1:
					result = await r.ReporteDeEstadisticasPromedioDeVoltajesDeProducto(comboBox1.SelectedValue.ToString(), dateTimePicker1.Value, dateTimePicker2.Value);
					await GenerarReporteConGrafica(result, "voltajes.pdf", "voltajes");
					Process.Start("voltajes.pdf");
					break;
				case 2:
					break;

				default:
					MessageBox.Show("Opcion incorrecta, seleccione otro reporte por favor");
					break;
			}
		}

		public async Task GenerarReporteConGrafica(DataTable datos, string nombreArchivoPDF, string title)
		{
			// Crear la gráfica
			Chart chart = new Chart();
			chart.Width = 600;
			chart.Height = 400;
			ChartArea area = new ChartArea();
			area.AxisX.Title = "Cable";
			area.AxisY.Title = title.Contains("voltaje") ? "Voltaje (V)" : "Resistencia (Ω)";
			area.AxisY.MajorGrid.LineColor = Color.LightGray;
			chart.ChartAreas.Add(area);

			// Serie de promedio medido
			Series serieMedido = new Series("Promedio Medido");
			serieMedido.ChartType = SeriesChartType.Column;
			serieMedido.Color = Color.SteelBlue;
			serieMedido.IsValueShownAsLabel = true;

			// Serie de esperado (línea de referencia)
			Series serieEsperado = new Series("Esperado");
			serieEsperado.ChartType = SeriesChartType.Line;
			serieEsperado.Color = Color.OrangeRed;
			serieEsperado.BorderWidth = 3;
			serieEsperado.IsValueShownAsLabel = true;

			foreach (DataRow row in datos.Rows)
			{
				string cable = row["Cable"].ToString();
				double promedio = Convert.ToDouble(row["PromedioMedido"]);
				double esperado = Convert.ToDouble(row["Esperado"]);

				serieMedido.Points.AddXY(cable, promedio);
				serieEsperado.Points.AddXY(cable, esperado);
			}

			chart.Series.Add(serieMedido);
			chart.Series.Add(serieEsperado);


			// Guardar imagen de la gráfica
			string rutaImagen = Path.Combine(Path.GetTempPath(), "grafica.png");
			chart.SaveImage(rutaImagen, ChartImageFormat.Png);

			// Crear documento PDF
			Document doc = new Document(PageSize.A4);
			PdfWriter.GetInstance(doc, new FileStream(nombreArchivoPDF, FileMode.Create));
			doc.Open();

			// Agregar título
			doc.Add(new Paragraph($"Reporte: Promedio de {title} por Cable", new iTextSharp.text.Font() { Size=24, Color=iTextSharp.text.BaseColor.BLUE} ));
			doc.Add(new Paragraph($"Fecha: {DateTime.Now}"));
			doc.Add(new Paragraph(" "));

			// Agregar tabla
			PdfPTable table = new PdfPTable(datos.Columns.Count);
			foreach (DataColumn col in datos.Columns)
				table.AddCell(new Phrase(col.ColumnName));

			foreach (DataRow row in datos.Rows)
			{
				foreach (var item in row.ItemArray)
					table.AddCell(new Phrase(item.ToString()));
			}
			doc.Add(table);

			// Agregar imagen
			iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(rutaImagen);
			img.ScaleToFit(500f, 400f);
			doc.Add(new Paragraph(" "));
			doc.Add(new Paragraph("Gráfica de Promedios:"));
			doc.Add(img);

			doc.Close();
		}
	}
}
