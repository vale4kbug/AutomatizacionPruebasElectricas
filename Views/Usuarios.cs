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
	public partial class Usuarios : Form
	{
		ClsUsuarios users;

		public Usuarios()
		{
			InitializeComponent();
			users = new ClsUsuarios();
			users.sendDatos = SettingUserInForm;
		}

		private void SettingUserInForm(DataTable datos)
		{
			if (datos.Rows.Count > 0)
			{
				txtNombre.Text = datos.Rows[0][0].ToString();
				txtApellido.Text = datos.Rows[0][1].ToString();
				dtFecha.Value = DateTime.Parse(datos.Rows[0][2].ToString());
				txtUsername.Text = datos.Rows[0][4].ToString();
				txtPassword.Text = datos.Rows[0][5].ToString();
			}
		}

		private void Usuarios_Load(object sender, EventArgs e)
		{
			dtFecha.MaxDate = DateTime.Now;
		}

		private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (chkShowPassword.Checked)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private async void txtUserID_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				await users.GetUser(txtUserID.Text);
			}
		}
	}
}
