using AutomatizacionPruebasElectricas.Classes;
using AutomatizacionPruebasElectricas.Views;
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
		private string id;

		public Menu(string nombre, string id)
		{
			InitializeComponent();
			Text = "Bienvenid@, " + nombre;
			this.id = id;
		}

		public Menu(string nombre)
		{
			InitializeComponent();
		}

		private void btnRegistroProducto_Click(object sender, EventArgs e)
		{
			Productos productos = new Productos();
			productos.Show();
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

		private void btnRegistroProducto_Click_1(object sender, EventArgs e)
		{
			Productos productos = new Productos();
			productos.Show();
		}

		private void BtnUsuarios_Click(object sender, EventArgs e)
		{
			Usuarios user = new Usuarios();
			user.ShowDialog();
			Menu_Load(sender, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Ventas ventas = new Ventas();
			ventas.Show();
		}

		private void btnEspecificaciones_Click(object sender, EventArgs e)
		{
			Especificaciones especificaciones = new Especificaciones();
			especificaciones.Show();
		}

		private void btnProcedimientos_Click(object sender, EventArgs e)
		{
			Procedimientos procedimientos = new Procedimientos();
			procedimientos.Show();
		}

		public List<Button> GetAllButtons(Control parent)
		{
			List<Button> buttons = new List<Button>();

			foreach (Control control in parent.Controls)
			{
				if (control is Button button)
				{
					buttons.Add(button);
				}
				else if (control.HasChildren)
				{
					buttons.AddRange(GetAllButtons(control));
				}
			}
			return buttons;
		}

		private async void Menu_Load(object sender, EventArgs e)
		{
			List<Button> botones = GetAllButtons(this);

			// Ocultar todos los botones
			foreach (var boton in botones)
			{
				boton.Visible = false;
			}

			ClsUsuarios user = new ClsUsuarios();
			DataTable modulos = await user.GetModulosDeUsuario(id);

			// Mostrar solo los botones que están en el DataTable
			foreach (DataRow row in modulos.Rows)
			{
				string nombreBoton = row["Descripcion"].ToString(); // Asegúrate de que esta sea la columna correcta

				Button botonEncontrado = botones.FirstOrDefault(b => b.Name == nombreBoton);
				if (botonEncontrado != null)
				{
					botonEncontrado.Visible = true;
				}
			}
			button1.Visible = true;	

        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            Lineas linea = new Lineas();
            linea.ShowDialog();
        }

        private void btnEstacion_Click(object sender, EventArgs e)
        {
            Estacion estacion = new Estacion();
            estacion.Show();
        }
		
        private void button1_Click_1(object sender, EventArgs e)
        {
			PruebaManual pruebaManual = new PruebaManual();
			pruebaManual.Show();
        }
    }
}
