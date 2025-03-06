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
	public partial class BuscarUsuario : Form
	{
		public Action<string> sendId;

		ClsUsuarios user;
		public BuscarUsuario()
		{
			InitializeComponent();
			user = new ClsUsuarios();

		}

		private async void txtFiltro_TextChanged(object sender, EventArgs e)
		{
			txtFiltro.Enabled = false;
			DataTable usuarios = await user.GetUsers(txtFiltro.Text);
			dgUsuarios.DataSource = usuarios;
			txtFiltro.Enabled = true;
			txtFiltro.Focus();
		}

		private async void BuscarUsuario_Load(object sender, EventArgs e)
		{
			DataTable users = await user.GetUsers(txtFiltro.Text);
			dgUsuarios.DataSource = users;
		}

		private void dgUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int id = int.Parse(dgUsuarios.Rows[dgUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString());
			MessageBox.Show(id.ToString());
		}

		private void dgUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			//string id = dgUsuarios.Rows[dgUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString();
			//sendId(id);
			//Close();
		}

		private void dgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			string id = dgUsuarios.Rows[dgUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString();
			sendId(id);
			Close();
		}

		private void dgUsuarios_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				string id = dgUsuarios.Rows[dgUsuarios.SelectedRows[0].Index].Cells[0].Value.ToString();
				sendId(id);
				Close();
			}
		}
	}
}
