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

namespace AutomatizacionPruebasElectricas
{
	public partial class Login : Form
	{

        ClsMultiConnection cls = new ClsMultiConnection("USB0::0x05E6::0x2100::1242285::INSTR");
        
		public Login()
		{
			InitializeComponent();
            cls.sendValue = metodo;
        }

		private void btnAbout_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Proyecto de Automatizacion de Pruebas Electricas v.1.0 \n" +
				"Para la clase Instrumentación Y Mediciones Eléctricas \n" +
				"Creado por: \n" +
				"Chavira Herrera Valeria Esperanza \n" +
				"Gonzales Rodrigues Roberto \n" +
				"Valdez Muñoz Bryan Allan \n" +
				"Zamorano Moreno Roman", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void HabilitarControles(bool estado)
		{
			btnIngresar.Enabled = estado;
			txtUsuarioContrasena.Enabled = estado;
			txtUsuarioLogin.Enabled = estado;
		}

		private async void Ingresar()
		{

			ClsLogin login = new ClsLogin();
			HabilitarControles(false);
			lblMensaje.Text = "Cargando ...";
			lblMensaje.Visible = true;

			bool acceso = await login.Log(txtUsuarioLogin.Text, txtUsuarioContrasena.Text);
			if (acceso)
			{
				string nombre = await login.GetUserFullName();
				Menu menu = new Menu(nombre, login.UsuarioId);
				menu.Show();
				Hide();
			}
			else
			{
				HabilitarControles(true);
				lblMensaje.Text = "El usuario o contraseña son incorrectos, intenta de nuevo";
				await Task.Delay(3000);
				lblMensaje.Visible = false;
			}
		}

		private void btnIngresar_Click(object sender, EventArgs e)
		{
			Ingresar();
		}

		private void txtUsuarioContrasena_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Ingresar();
			}
		}

        private void button1_Click(object sender, EventArgs e)
        {
			
			//cls.MedirVoltaje();
        }

        private void metodo(string obj)
        {
			MessageBox.Show(obj);
        }

        private void button2_Click(object sender, EventArgs e)
        {
			//cls.MedirResistencia();
        }
    }
}
