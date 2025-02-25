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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proyecto de Automatizacion de Pruebas Electricas v.1.0 \n" +
                "Para la clase Instrumentación Y Mediciones Eléctricas \n" +
                "Creado por: \n" +
                "Chavira Herrera Valeria Esperanza \n" +
                "Gonzales Rodrigues Roberto \n" +
                "Valdez Muñoz Bryan Allan \n" +
                "Zamorano Moreno Roman", "About", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
