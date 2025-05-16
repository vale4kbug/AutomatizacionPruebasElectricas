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

            if (txtNoSerie.Enabled == true)
            {
                int resultado = await productos.PutProducto(txtModelo.Text, richDescripcion.Text);
                txtNoSerie.Text = resultado.ToString();
                txtNoSerie.Enabled = false;              
                
                await productos.DeleteTodosEspecificacionesProducto(txtNoSerie.Text);
                await productos.DeleteTodosProcedimientosProducto(txtNoSerie.Text);

                foreach (DataGridViewRow row in dataEspecificaciones.Rows)
                {
                    string idEspecificacion = row.Cells[0].Value.ToString();
                    string valor = row.Cells[2].Value.ToString();

                    await productos.EspecificacionesPutProducto(txtNoSerie.Text, idEspecificacion, valor);
                }

                foreach (DataRow proc in procedimientos.Rows)
                {
                    string idProcedimiento = proc["IDProcedimiento"].ToString();
                    string descripcion = proc["Descripcion"].ToString();

                    await productos.ProcedimientosPutProducto(txtNoSerie.Text, idProcedimiento);
                }
              
                MessageBox.Show("Producto creado, favor de verificarlo");
            }
            else
            {
                await productos.PutProducto(txtNoSerie.Text, txtModelo.Text, richDescripcion.Text);
                foreach (DataGridViewRow row in dataEspecificaciones.Rows)

                await productos.DeleteTodosEspecificacionesProducto(txtNoSerie.Text);
                await productos.DeleteTodosProcedimientosProducto(txtNoSerie.Text);

                foreach (DataGridViewRow row in dataEspecificaciones.Rows)
                {
                    string idEspecificacion = row.Cells[0].Value.ToString();
                    string valor = row.Cells[2].Value.ToString();

                    await productos.EspecificacionesPutProducto(txtNoSerie.Text, idEspecificacion, valor);
                }

                foreach (DataRow proc in procedimientos.Rows)
                {
                    string idProcedimiento = proc["IDProcedimiento"].ToString();
                    string descripcion = proc["Descripcion"].ToString();

                    await productos.ProcedimientosPutProducto(txtNoSerie.Text, idProcedimiento);
                }
                MessageBox.Show("Producto actualizado", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAgregasEspecificacion_Click(object sender, EventArgs e)
        {
            BuscarEspecificaciones especificaciones = new BuscarEspecificaciones() { sendId = SetNewSpecInForm };
            especificaciones.Show();
        }

        private async void btnEliminarEspecificaciones_Click(object sender, EventArgs e)
        {
            if (dataEspecificaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataEspecificaciones.SelectedRows[0];

                string idEspecificacion = selectedRow.Cells[0].Value.ToString();
                string idProducto = txtNoSerie.Text;

                if (MessageBox.Show("¿Seguro que quieres eliminar esta especificación?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                      dataEspecificaciones.Rows.Remove(selectedRow);
                     MessageBox.Show("Especificación eliminada correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila de especificación para eliminar.");
            }

        }

        private void btnAgregarProcedimientos_Click(object sender, EventArgs e)
        {
            BuscarProcedimientos procedimientos = new BuscarProcedimientos() { sendId = SetNewProcInForm };
            procedimientos.Show();
        }

        private  void btnEliminarProcedimientos_Click(object sender, EventArgs e)
        {
            if (listBoxProcedimientos.SelectedItem != null)
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar este procedimiento?", "Confirmar Eliminación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    procedimientos.Rows.RemoveAt(listBoxProcedimientos.SelectedIndex);

                        MessageBox.Show("Procedimiento eliminado correctamente.");
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
            //listBoxEspecificaciones.Items.Clear();
          //  listBoxProcedimientos.Items.Clear();
            txtNoSerie.Focus();

        }

        DataTable procedimientos;

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
                ////listBoxEspecificaciones.Items.Clear();
                foreach (DataRow row in especificaciones.Rows)
                {
                    dataEspecificaciones.Rows.Add(row[0], row[1], row[2]);
                }

                // Cargar procedimientos
                procedimientos = await productos.GetProcedimientosProducto(txtNoSerie.Text);
                listBoxProcedimientos.DataSource = procedimientos;
                listBoxProcedimientos.DisplayMember = "Descripcion";
                listBoxProcedimientos.ValueMember = "IDProcedimiento";
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

        private async void SetNewSpecInForm(string id)
        {
            DataTable datos = await productos.GetEspecificacion(id);

            dataEspecificaciones.Rows.Add(datos.Rows[0][0], datos.Rows[0][1], datos.Rows[0][2]);
        }

        private async void SetNewProcInForm(string id)
        {
            DataTable datos = await productos.GetProcedimiento(id);

            if (datos != null && datos.Rows.Count > 0)
            {
                // Asegurarse de que procedimientos esté inicializado
                if (procedimientos == null)
                {
                    procedimientos = new DataTable();
                    procedimientos.Columns.Add("IDProcedimiento");
                    procedimientos.Columns.Add("Descripcion");
                    procedimientos.Rows.Add(datos.Rows[0][0], datos.Rows[0][1]);
                    ActualizarListBoxProcedimientos();

                }

                procedimientos.Rows.Add(datos.Rows[0][0], datos.Rows[0][1]);
            }
            else
            {
                MessageBox.Show("No se encontró el procedimiento con ese ID.");
            }
        }

        private void ActualizarListBoxProcedimientos()
        {
            listBoxProcedimientos.DataSource = null;
            listBoxProcedimientos.DisplayMember = "Descripcion"; // o el campo que quieras mostrar
            listBoxProcedimientos.ValueMember = "IDProcedimiento";
            listBoxProcedimientos.DataSource = procedimientos;
        }


    }
}
