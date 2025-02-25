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
    public partial class PersonalActual : Form
    {
        public PersonalActual()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menuforma = new Menu("");
            this.Hide();
            menuforma.Show();
        }
    }
}
