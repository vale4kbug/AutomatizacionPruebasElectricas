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
	public partial class Menu : Form
	{
		public Menu(string nombre)
		{
			InitializeComponent();
			Text = "Bienvenid@, " + nombre;
		}

		private void btnRegistroProducto_Click(object sender, EventArgs e)
		{

		}

		private void btnRegistroPersonal_Click(object sender, EventArgs e)
		{
			RegistroPersonal registroPersonal = new RegistroPersonal();
			registroPersonal.ShowDialog();
		}

		private void btnPruebas_Click(object sender, EventArgs e)
		{
			Pruebas pruebas = new Pruebas();
			pruebas.Show();
		}

		private void Menu_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}
	}
}
