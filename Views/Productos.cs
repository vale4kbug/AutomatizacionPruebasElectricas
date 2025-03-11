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
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menuforma = new Menu("");
            this.Hide();
            menuforma.Show();
        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            ClsProductos productos = new ClsProductos();

            if (txtNoSerie.Text=="" || txtModelo.Text==""||richDescripcion.Text=="")
            {
                MessageBox.Show("Revisa los campos correctamente","Error al tratar de agregar nuevo producto",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void btnAgregasEspecificacion_Click(object sender, EventArgs e)
        {
            Especificaciones especificaciones = new Especificaciones();
            especificaciones.Show();
        }

        private void btnEliminarEspecificaciones_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarProcedimientos_Click(object sender, EventArgs e)
        {
            Procedimientos procedimientos = new Procedimientos();
            procedimientos.Show();
        }

        private void btnEliminarProcedimientos_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarProductos buscarproductos = new BuscarProductos();
            buscarproductos.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNoSerie.Text = "";
            txtModelo.Text = "";
            richDescripcion.Text = "";
            listBoxEspecificaciones.Items.Clear();
            listBoxProcedimientos.Items.Clear();
        }
    }
}
