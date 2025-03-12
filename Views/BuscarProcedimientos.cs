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
    public partial class BuscarProcedimientos : Form
    {
        public Action<string> sendId;

        ClsProductos procedimiento;
        public BuscarProcedimientos()
        {
            InitializeComponent();
            procedimiento = new ClsProductos();

        }

        private void BuscarProcedimientos_Load(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            txtFiltro.Enabled = false;
          
        }
    }
}
