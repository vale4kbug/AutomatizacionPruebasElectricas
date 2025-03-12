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
    public partial class BuscarProductos : Form
    {


        ClsProductos products;
        public Action<string> sendId;

        public BuscarProductos()
        {
            InitializeComponent();
            products=new ClsProductos();
        }

        private async void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            txtFiltro.Enabled = false;
            DataTable productos = await products.GetProductos(txtFiltro.Text);
            dgProductos.DataSource = products;
            txtFiltro.Enabled = true;
            txtFiltro.Focus();  
        }

        private async void BuscarProductos_Load(object sender, EventArgs e)
        {
            DataTable productosData = await products.GetProductos(txtFiltro.Text);
            dgProductos.DataSource = productosData;
        }

        private void dgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dgProductos.Rows[dgProductos.SelectedRows[0].Index].Cells[0].Value.ToString());
            MessageBox.Show(id.ToString());
        }

        private void dgProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgProductos.Rows[dgProductos.SelectedRows[0].Index].Cells[0].Value.ToString();
            sendId(id);
            Close();
        }

        private void dgProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string id = dgProductos.Rows[dgProductos.SelectedRows[0].Index].Cells[0].Value.ToString();
                sendId(id);
                Close();
            }
        }
    }
}
