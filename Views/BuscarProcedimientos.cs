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

        ClsProcedimientos procedimiento;
        public BuscarProcedimientos()
        {
            InitializeComponent();
            procedimiento = new ClsProcedimientos();

        }

        private async void BuscarProcedimientos_Load(object sender, EventArgs e)
        {
            DataTable procedimientos = await procedimiento.GetProcedimientos(txtFiltro.Text);
            dgProcedimientos.DataSource = procedimientos;
        }

        private async void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            txtFiltro.Enabled = false;
            DataTable procedimientos = await procedimiento.GetProcedimientos(txtFiltro.Text);
            dgProcedimientos.DataSource = procedimientos;
            txtFiltro.Enabled = true;
            txtFiltro.Focus();
        }

        private void dgProcedimientos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgProcedimientos.Rows[dgProcedimientos.SelectedRows[0].Index].Cells[0].Value.ToString();
            sendId(id);
            Close();
        }

        private void dgProcedimientos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = dgProcedimientos.Rows[dgProcedimientos.SelectedRows[0].Index].Cells[0].Value.ToString();
                sendId(id);
                Close();
            }
        }

        private void dgProcedimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
