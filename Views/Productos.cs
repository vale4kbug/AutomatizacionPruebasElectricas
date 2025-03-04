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
    }
}
