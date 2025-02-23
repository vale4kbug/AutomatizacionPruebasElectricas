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
    public partial class RegistroPersonal : Form
    {
        public RegistroPersonal()
        {
            InitializeComponent();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            Menu menuforma = new Menu();
            this.Hide();
            menuforma.Show();
        }

        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            if (true)
            {
                MessageBox.Show("Usuario Registrado." +
                  "Usuario registrado correctamente.", "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error: No es posible registrar el usuario." +
                    "Checa que todos los campos esten llenos.", "Error XoX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarPersonal_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
           else if (true)
            {
                MessageBox.Show("Error: No es posible eliminar el usuario." +
                 "El usuario no existe. Revisa los datos", "Error XoX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Error: No es posible eliminar el usuario." +
                   "Revisa que todos los campos esten llenos.", "Error XoX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarPersonal_Click(object sender, EventArgs e)
        {
            if (true)
            {

            }
            else
            {
                MessageBox.Show("Error: No es posible modificar registrar el usuario." +
                "El usuario no existe. Revisa los datos", "Error XoX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
