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
	public partial class Especificaciones : Form
	{

		ClsEspecificaciones especificaciones;

		public Especificaciones()
		{
			InitializeComponent();
			especificaciones = new ClsEspecificaciones
			{
				sendDatos = SettingEspecificacionInForm
			};
		}

		private async void btnRegistrarProductos_Click(object sender, EventArgs e)
		{
			if (txtId.Enabled == true && richDescripcion.Text != "")
			{
				int id = await especificaciones.PutEspecificacion(txtId.Text, richDescripcion.Text, txtId.Text);
				txtId.Enabled = false;
				txtId.Text = id.ToString();

				MessageBox.Show("Especificaciones creada, favor de verificarlo");
			}
			else
			{
				await especificaciones.PutEspecificacion(txtId.Text, richDescripcion.Text);
				MessageBox.Show("Producto actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private async void btnEliminarProductos_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estas seguro de eliminar este producto?", "Eliminar producto",
		   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				await especificaciones.DeleteEspecificacion(txtId.Text);
				MessageBox.Show($"Se elimino {richDescripcion.Text} de la base de datos", "Operacion completada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtId.Text = "";
				txtId.Enabled = true;
				richDescripcion.Text = "";
			}
		}

		private void btnBuscarProductos_Click(object sender, EventArgs e)
		{
			BuscarEspecificaciones buscarespecificaciones = new BuscarEspecificaciones();
			buscarespecificaciones.sendId = RecibirId;
			buscarespecificaciones.Show();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			txtId.Enabled = true;
			txtId.Text = "";
			richDescripcion.Text = "";
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			Menu menuforma = new Menu("", "");
			this.Hide();
			menuforma.Show();
		}

		private async void SettingEspecificacionInForm(DataTable datos)
		{
			if (datos.Rows.Count > 0)
			{
				txtId.Text = datos.Rows[0][0].ToString();
				richDescripcion.Text = datos.Rows[0][1].ToString();
				txtId.Enabled = false;
			}

		}
		private async void RecibirId(string obj)
		{
			txtId.Text = obj;
			await especificaciones.GetEspecificacion(txtId.Text);
		}

		private async void txtId_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				await especificaciones.GetEspecificacion(txtId.Text);
			}
		}

		private void Especificaciones_Load(object sender, EventArgs e)
		{

		}
	}
}
