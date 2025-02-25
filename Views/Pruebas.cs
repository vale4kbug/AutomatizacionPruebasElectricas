using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas
{
	public partial class Pruebas : Form
	{
		public Pruebas()
		{
			InitializeComponent();
		}

		bool bucle = true;
		List<string> list = new List<string>() { "Producto 1", "Producto 2", "Producto 3", "Producto 4", "Producto 5" };

		private async void BtnIniciar_Click(object sender, EventArgs e)
		{
			BtnIniciar.Enabled = false;
			BtnStop.Enabled = true;
			bucle = true;
			while (bucle)
			{
				await Task.Delay(1000);
				GenerarMedicion();
			}
		}

		private void GenerarMedicion()
		{
			Random rnd = new Random();
			int producto = rnd.Next(1, 5);

			double voltaje = rnd.Next(3, 7);

			double corriente = rnd.Next(8, 12);

			string state = "";

			if ((voltaje >= 4 && voltaje <= 6) && (corriente >= 9 && corriente <= 11))
			{
				state = "Aprobado";
			}
			else
			{
				state = "Reprobado";
			}

			dataGridView1.Rows.Add(producto,rnd.Next(0,9).ToString()+ rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString()+ rnd.Next(0, 9).ToString()+ rnd.Next(0, 9).ToString(), list[producto],  voltaje, corriente, state);

		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			bucle = false;
			BtnStop.Enabled = false;
			BtnIniciar.Enabled = true;
		}
	}
}
