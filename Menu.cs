﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnRegistroProducto_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistroPersonal_Click(object sender, EventArgs e)
        {
            RegistroPersonal registroPersonal = new RegistroPersonal();
            this.Hide();
            registroPersonal.Show();
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PersonalActual personalActualForma = new PersonalActual();
            this.Hide();
            personalActualForma.Show();
        }
    }
}
