using AutomatizacionPruebasElectricas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Views
{
	public partial class Lineas : Form
	{
		ClsLineas cls;

		public Lineas()
		{
			InitializeComponent();

			cls = new ClsLineas();
			cls.sendDatos = recibirDatos;
		}

		private void recibirDatos(DataTable table)
		{
			if (table.Rows.Count == 0)
				return;

			txtId.Enabled = false;
			txtId.Text = table.Rows[0][0].ToString();
			txtNombre.Text = table.Rows[0][1].ToString();
			richDescripcion.Text = table.Rows[0][3].ToString();
		}

		private void BtnAddModifyLinea_Click(object sender, EventArgs e)
		{

		}

		private void BtnDeleteLinea_Click(object sender, EventArgs e)
		{

		}

		private void txtId_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Enter)
				return;


		}
	}
}
