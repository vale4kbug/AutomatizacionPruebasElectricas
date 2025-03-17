using AutomatizacionPruebasElectricas.Classes;
using iTextSharp.text.xml;
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

        ClsProductos productos;
        public Productos()
        {
            InitializeComponent();
            productos = new ClsProductos
            {
                sendDatos = SettingProductoInForm
            };
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menuforma = new Menu("");
            this.Hide();
            menuforma.Show();
        }

        private async void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            if (txtNoSerie.Enabled==true)
            {
                int resultado = await productos.PutProducto(txtModelo.Text, richDescripcion.Text);
                await productos.PutProducto(txtModelo.Text, richDescripcion.Text);
                txtNoSerie.Text = resultado.ToString();
                txtNoSerie.Enabled = false;
                MessageBox.Show("Producto creado, favor de verificarlo");
            }
            else
            {
                await productos.PutProducto(txtNoSerie.Text, txtModelo.Text, richDescripcion.Text);
                MessageBox.Show("Producto actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregasEspecificacion_Click(object sender, EventArgs e)
        {
            BuscarEspecificaciones especificaciones = new BuscarEspecificaciones();
            especificaciones.Show();
        }

        private async void btnEliminarEspecificaciones_Click(object sender, EventArgs e)
        {
            if (listBoxEspecificaciones.SelectedItem != null)
            {
                string selectedItem = listBoxEspecificaciones.SelectedItem.ToString();
                string idEspecificacion = selectedItem.Split(':')[0].Trim();

                if (MessageBox.Show("¿Seguro que quieres eliminar esta especificación?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ClsEspecificaciones clsEspecificaciones = new ClsEspecificaciones();
                    int resultado = await clsEspecificaciones.DeleteEspecificacion(idEspecificacion);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Especificación eliminada correctamente.");
                        listBoxEspecificaciones.Items.Remove(selectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar la especificación.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una especificación para eliminar.");
            }
        }

        private void btnAgregarProcedimientos_Click(object sender, EventArgs e)
        {
            BuscarProcedimientos procedimientos = new BuscarProcedimientos();
            procedimientos.Show();
        }

        private async void btnEliminarProcedimientos_Click(object sender, EventArgs e)
        {
            if (listBoxProcedimientos.SelectedItem != null)
            {
                string selectedItem = listBoxProcedimientos.SelectedItem.ToString();
                string idProcedimiento = selectedItem.Split(':')[0].Trim(); // Extraer el ID del procedimiento

                if (MessageBox.Show("¿Seguro que quieres eliminar este procedimiento?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ClsProcedimientos clsProcedimientos = new ClsProcedimientos();
                    int resultado = await clsProcedimientos.DeleteProcedimiento(idProcedimiento);

                    if (resultado > 0)
                    {
                        MessageBox.Show("Procedimiento eliminado correctamente.");
                        listBoxProcedimientos.Items.Remove(selectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al eliminar el procedimiento.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un procedimiento para eliminar.");
            }
        }

        private async void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de eliminar este producto?", "Eliminar producto",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int resultado = await productos.DeleteProductoDomino(txtNoSerie.Text);
                MessageBox.Show($"Se elimino {resultado} producto y todo lo relacionado con el mismo", "Operacion completada correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            BuscarProductos buscarproductos = new BuscarProductos();
            buscarproductos.sendId = RecibirId;
            buscarproductos.Show();
        }
        private async void RecibirId(string obj)
        {
            txtNoSerie.Text = obj;
            await productos.GetProducto(txtNoSerie.Text);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNoSerie.Text = "";
            txtModelo.Text = "";
            richDescripcion.Text = "";
            listBoxEspecificaciones.Items.Clear();
            listBoxProcedimientos.Items.Clear();
            txtNoSerie.Focus();

        }

        private async void SettingProductoInForm(DataTable datos)
        {
            if (datos.Rows.Count > 0)
            {
                txtNoSerie.Text = datos.Rows[0][0].ToString();
                txtModelo.Text = datos.Rows[0][1].ToString();
                richDescripcion.Text = datos.Rows[0][2].ToString();
                txtNoSerie.Enabled = false;

                // Cargar especificaciones
                DataTable especificaciones = await productos.GetEspecificacionesProducto(txtNoSerie.Text);
                listBoxEspecificaciones.Items.Clear();
                foreach (DataRow row in especificaciones.Rows)
                {
                    listBoxEspecificaciones.Items.Add($"{row["IdEspecificacion"]}: {row["Descripcion"]} - {row["Valor"]}");
                }

                // Cargar procedimientos
                DataTable procedimientos = await productos.GetProcedimientosProducto(txtNoSerie.Text);
                listBoxProcedimientos.Items.Clear();
                foreach (DataRow row in procedimientos.Rows)
                {
                    listBoxProcedimientos.Items.Add($"{row["IdProcedimiento"]}: {row["Descripcion"]}");
                }
            }
        }


        private async void txtNoSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await productos.GetProducto(txtNoSerie.Text);
            }
        }

        private void listBoxEspecificaciones_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listBoxProcedimientos_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
