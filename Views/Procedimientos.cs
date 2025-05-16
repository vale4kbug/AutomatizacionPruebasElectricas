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
            procedimientos = new ClsProcedimientos();
            {
           //     sendDatos = SettingProcedimientosInForm;
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
                int resultado = await procedimientos.PutProcedimiento( richDescripcion.Text);
                await procedimientos.PutProcedimiento(richDescripcion.Text);
                txtId.Text = resultado.ToString();
                txtId.Enabled = false;
                MessageBox.Show("Procedimientos creado, favor de verificarlo");
            }
            else
            {
                await procedimientos.PutProcedimiento(txtId.Text, richDescripcion.Text);
                MessageBox.Show("Producto actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void btnEliminarProcedimientos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar este procedimiento?", "Eliminar producto",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = await procedimientos.DeleteProcedimiento(txtId.Text);
                MessageBox.Show($"Se elimino {resultado} producto y todo lo relacionado con el mismo", "Operacion completada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtId.Focus();

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
    }
}
