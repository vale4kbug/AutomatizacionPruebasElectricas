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
            if (txtId.Enabled == true)
            {
                int resultado = await especificaciones.PutEspecificacion(richDescripcion.Text);
                await especificaciones.PutEspecificacion(txtId.Text, richDescripcion.Text);
                txtId.Text = resultado.ToString();
                txtId.Enabled = false;
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
                int resultado = await especificaciones.DeleteEspecificacion(txtId.Text);
                MessageBox.Show($"Se elimino {resultado} de la base de datos", "Operacion completada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtId.Text = "";
            richDescripcion.Text = "";
            txtId.Focus();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menuforma = new Menu("");
            this.Hide();
            menuforma.Show();
        }

        private async void SettingEspecificacionInForm(DataTable datos)
        {


        }
        private async void RecibirId(string obj)
        {
            txtId.Text = obj;
            await especificaciones.GetEspecificacion(txtId.Text);
        }
    }
}
