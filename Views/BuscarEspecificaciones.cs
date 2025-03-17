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
    public partial class BuscarEspecificaciones : Form
    {
        public Action<string> sendId;

        ClsEspecificaciones especificacion;
        public BuscarEspecificaciones()
        {
            InitializeComponent();
            especificacion = new ClsEspecificaciones();
        }
        private async void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            txtFiltro.Enabled = false;
            DataTable especificaciones = await especificacion.GetEspecificaciones(txtFiltro.Text);
            dgEspecificaciones.DataSource = especificaciones;
            txtFiltro.Enabled = true;
            txtFiltro.Focus();
        }

        private  async void BuscarEspecificaciones_Load(object sender, EventArgs e)
        {
            DataTable especificaciones = await especificacion.GetEspecificaciones(txtFiltro.Text);
            dgEspecificaciones.DataSource = especificaciones;
        }

        private void dgEspecificaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgEspecificaciones.Rows[dgEspecificaciones.SelectedRows[0].Index].Cells[0].Value.ToString());
            MessageBox.Show(id.ToString());
        }

        private void dgEspecificaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgEspecificaciones.Rows[dgEspecificaciones.SelectedRows[0].Index].Cells[0].Value.ToString();
            sendId(id);
            Close();
        }

        private void dgEspecificaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = dgEspecificaciones.Rows[dgEspecificaciones.SelectedRows[0].Index].Cells[0].Value.ToString();
                sendId(id);
                Close();
            }
        }
    }
}
