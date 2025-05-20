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
	public partial class Procedimientos : Form
	{
		ClsProcedimientos procedimientos;

		public Procedimientos()
		{
			InitializeComponent();
			procedimientos = new ClsProcedimientos
			{
				sendDatos = SettingProcedimientosInForm
			};

		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			Menu menuforma = new Menu("");
			this.Hide();
			menuforma.Show();
		}

		private async void btnRegistrarProcedimientos_Click(object sender, EventArgs e)
		{
			if (txtId.Enabled == true)
			{
				await procedimientos.PutProcedimiento(txtId.Text, richDescripcion.Text, txtId.Text);
				txtId.Enabled = false;
				MessageBox.Show("Procedimientos creado, favor de verificarlo");
			}
			else
			{
				await procedimientos.PutProcedimiento(txtId.Text, richDescripcion.Text);
				txtId.Enabled = true;
				MessageBox.Show("Producto actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private async void btnEliminarProcedimientos_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Estas seguro de eliminar este procedimiento?", "Eliminar producto",
			MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				await procedimientos.DeleteProcedimiento(txtId.Text);
                await procedimientos.DeleteProcedimientoenOtros(txtId.Text);

                MessageBox.Show($"Se elimino {richDescripcion.Text} producto y todo lo relacionado con el mismo", "Operacion completada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
				txtId.Text = "";
				richDescripcion.Text = "";

			}
		}

		private void btnBuscarProcedimientos_Click(object sender, EventArgs e)
		{
			BuscarProcedimientos buscarprocedimientos = new BuscarProcedimientos();
			buscarprocedimientos.sendId = RecibirId;
			buscarprocedimientos.Show();
		}

		private void btnLimpiarProcedimientos_Click(object sender, EventArgs e)
		{
			txtId.Text = "";
			richDescripcion.Text = "";

		}


		private async void SettingProcedimientosInForm(DataTable datos)
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
			await procedimientos.GetProcedimiento(txtId.Text);
		}

		private async void txtId_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				await procedimientos.GetProcedimiento(txtId.Text);
			}
		}
	}
}
