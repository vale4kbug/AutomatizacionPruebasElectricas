using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsUsuarios : ClsConnection
	{
		public Action<DataTable> sendDatos;

		public async Task<DataTable> GetUsers(string filtro)
		{
			DataTable usuarios = await GetTable($"select idUsuario as ID, nombre as Nombre, apellido as Apellido, username as Usuario from usuarios " +
				$"where nombre like '%{filtro}%' or apellido='%{filtro}%' or username='%{filtro}%' or IDUsuario like '%{filtro}%'");
			return usuarios;
		}

		public async Task GetUser(string id)
		{
			DataTable datosUsuario = await GetTable("select Nombre, Apellido, FechaContratacion, FotoRuta, Username, Contraseña " +
				$"from usuarios where IDUsuario = {id}");

			sendDatos(datosUsuario);
		}

		//Metodo para insertar un usuario
		public async Task<int> PutUser(string nombre, string apellido, DateTime fechaContratacion, string fotoRuta, string username, string password)
		{
			return await PutInDatabase("insert into usuarios (nombre, apellido, FechaContratacion, FotoRuta, username, contraseña) " +
				$"values ('{nombre}', '{apellido}', '{fechaContratacion:yyyy-MM-dd HH:mm:ss}', '{fotoRuta}', '{username}', '{password}');" +
				$"SELECT LAST_INSERT_ID();");
		}

		//Metodo para actualizar un usuario, sobrecarga al metodo anterior
		public async Task PutUser(string id, string nombre, string apellido, DateTime fechaContratacion, string fotoRuta, string username, string password)
		{
			await PutInDatabase($"UPDATE usuarios SET nombre='{nombre}', apellido='{apellido}', FechaContratacion='{fechaContratacion:yyyy-MM-dd HH:mm:ss}'," +
				$"FotoRuta='{fotoRuta}', username='{username}', Contraseña='{password}' where IDUsuario='{id}'");
		}

		//Metodo para eliminar un usuario
		public async Task<int> DeleteUser(string id)
		{
			return await PutInDatabase($"delete from usuarios where IDUsuario='{id}'");
		}

		public async Task<string> GenerarCredencial(string userID)
		{
			DataTable datosUsuario = await GetTable($"SELECT IDUsuario, Nombre, Apellido, FechaContratacion, FotoRuta, Username FROM usuarios WHERE IDUsuario = {userID}");

			if (datosUsuario.Rows.Count == 0)
			{
				MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}

			// Extraer datos del usuario
			string id = datosUsuario.Rows[0]["IDUsuario"].ToString();
			string nombre = datosUsuario.Rows[0]["Nombre"].ToString();
			string apellido = datosUsuario.Rows[0]["Apellido"].ToString();
			string fecha = Convert.ToDateTime(datosUsuario.Rows[0]["FechaContratacion"]).ToShortDateString();
			string username = datosUsuario.Rows[0]["Username"].ToString();
			string fotoRuta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FotosUsuarios", datosUsuario.Rows[0]["FotoRuta"].ToString());

			// Ruta donde se guardará el PDF
			string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"Credencial_{id}.pdf");

			// Definir el tamaño de la credencial (Tarjeta ID)
			Document doc = new Document(new Rectangle(250, 400)); // Ancho x Alto en puntos (72 puntos = 1 pulgada)
			PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
			doc.Open();

			// Crear tabla para organizar la credencial
			PdfPTable table = new PdfPTable(1);
			table.WidthPercentage = 100;

			// Estilo de fuente
			Font fontBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
			Font fontNormal = FontFactory.GetFont(FontFactory.HELVETICA, 12);

			// Agregar el título de la credencial
			PdfPCell titleCell = new PdfPCell(new Phrase("CREDENCIAL DE EMPLEADO", fontBold));
			titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
			titleCell.Border = Rectangle.NO_BORDER;
			titleCell.PaddingBottom = 10;
			table.AddCell(titleCell);

			// Agregar información del usuario
			table.AddCell(GetFormattedCell($"ID: {id}", fontNormal));
			table.AddCell(GetFormattedCell($"Nombre: {nombre} {apellido}", fontNormal));
			table.AddCell(GetFormattedCell($"Fecha de Contratación: {fecha}", fontNormal));
			table.AddCell(GetFormattedCell($"Usuario: {username}", fontNormal));

			// Insertar foto si existe
			if (File.Exists(fotoRuta))
			{
				iTextSharp.text.Image foto = iTextSharp.text.Image.GetInstance(fotoRuta);
				foto.ScaleToFit(100, 100); // Ajustar el tamaño de la imagen
				foto.Alignment = Element.ALIGN_CENTER;
				PdfPCell fotoCell = new PdfPCell(foto);
				fotoCell.HorizontalAlignment = Element.ALIGN_CENTER;
				fotoCell.Border = Rectangle.NO_BORDER;
				table.AddCell(fotoCell);
			}
			else
			{
				table.AddCell(GetFormattedCell("Foto no disponible", fontNormal));
			}

			// Agregar tabla al documento
			doc.Add(table);
			doc.Close();

			MessageBox.Show($"PDF generado en {pdfPath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return pdfPath;
		}

		// Método auxiliar para formatear celdas
		private PdfPCell GetFormattedCell(string text, Font font)
		{
			PdfPCell cell = new PdfPCell(new Phrase(text, font));
			cell.Border = Rectangle.NO_BORDER;
			cell.PaddingBottom = 5;
			return cell;
		}
	}
}
