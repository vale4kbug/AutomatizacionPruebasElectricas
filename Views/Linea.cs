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
    public partial class Linea : Form
    {
        public Linea()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
			AutomatizacionPruebasElectricas.Estacion menuforma = new AutomatizacionPruebasElectricas.Estacion("");
            this.Hide();
            menuforma.Show();
        }
    }
}
