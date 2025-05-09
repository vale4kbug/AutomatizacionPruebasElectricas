using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AutomatizacionPruebasElectricas.Classes;
using MySql.Data.MySqlClient;

namespace AutomatizacionPruebasElectricas
{
    public partial class Pruebas : Form
    {
        private ClsMedicion gestorMediciones = new ClsMedicion(); // Instancia de la clase ClsMedicion
        private List<string> listaNoSerieProductos = new List<string>();

        public Pruebas()
        {
            InitializeComponent();
            // Make MedicionGrafica fill the left half of groupBox1


            // Anchor labels so they stay near their intended positions
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

            groupBox1.Location = new System.Drawing.Point(10, 50); // 50 pixels from top
            groupBox1.Width = this.ClientSize.Width - 20; // 10px margin on each side

            // This makes the GroupBox resize with the form
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            this.Controls.Add(groupBox1);

            // Handle form resize to maintain top margin
            this.Resize += (sender, e) =>
            {
                // Maintain 50px top margin while resizing
                groupBox1.Height = this.ClientSize.Height - 60; // 50px top + 10px bottom
            };
        }


        // Variable para controlar el bucle de generación de datos
        private bool bucle = true;

        // Lista de productos para la simulación (solo descripciones ahora)
        private List<string> productosDescripcion = new List<string>() { "Producto 1", "Producto 2", "Producto 3", "Producto 4", "Producto 5" };

        // BackgroundWorker para la generación de datos en segundo plano
        private BackgroundWorker dataWorker;

        // Variable para almacenar el valor actual de voltaje
        private double voltajeActual = 0;

        // Timer para actualizar el gráfico
        private Timer timer;

        // Número máximo de puntos a mostrar antes de hacer scroll
        private const int MaxPuntos = 30;

        // Contador para el eje X (tiempo)
        private int contadorTiempo = 0;

        // Contador para el número de mediciones generadas
        private int contadorMediciones = 0;

        private async Task CargarProductosParaPrueba()
        {
            // Asume que tienes un método en ClsMedicion (o crea ClsProducto)
            // para obtener una lista de todos los NoSerie de la tabla producto.
            // ¡Debes implementar este método en ClsMedicion!
            DataTable tablaProductos = await gestorMediciones.ObtenerNoSerieProductos();

            if (tablaProductos != null)
            {
                listaNoSerieProductos.Clear(); // Limpiar la lista anterior
                cmbProducto.Items.Clear();     // Limpiar los items del ComboBox

                foreach (DataRow fila in tablaProductos.Rows)
                {
                    string noSerie = fila["NoSerie"].ToString();
                    listaNoSerieProductos.Add(noSerie);
                    cmbProducto.Items.Add(noSerie); // Agregar el NoSerie al ComboBox
                }

                // Opcional: Seleccionar el primer producto por defecto
                if (cmbProducto.Items.Count > 0)
                {
                    cmbProducto.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Error al cargar los productos para prueba.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarGrafico()
        {
            // Clear all existing series
            MedicionGrafica.Series.Clear();

            // Create new series
            var serie = new Series("Voltaje")
            {
                ChartType = SeriesChartType.Line
            };
            MedicionGrafica.Series.Add(serie);

            // Reset chart area settings
            var chartArea = MedicionGrafica.ChartAreas[0];
            chartArea.AxisX.Title = "Tiempo";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = MaxPuntos;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisY.Title = "Voltaje";
        }
        private void HabilitarDobleBuffer(Chart chart)
        {
            // Usar reflexión para habilitar el doble buffer
            var propiedadDobleBuffer = chart.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            if (propiedadDobleBuffer != null)
            {
                propiedadDobleBuffer.SetValue(chart, true, null);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Agregar el valor al gráfico en el hilo de la UI
            MedicionGrafica.Series[0].Points.AddXY(contadorTiempo, voltajeActual);

            // Incrementar el contador de tiempo
            contadorTiempo++;

            // Hacer scroll del gráfico si el número de puntos excede MaxPuntos
            if (contadorTiempo > MaxPuntos)
            {
                // Ajustar el mínimo y máximo del eje X para crear el efecto de scroll
                MedicionGrafica.ChartAreas[0].AxisX.Minimum = contadorTiempo - MaxPuntos;
                MedicionGrafica.ChartAreas[0].AxisX.Maximum = contadorTiempo;
            }
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            BtnIniciar.Enabled = false;
            BtnStop.Enabled = true;
            bucle = true;

            // 1. Clear the Chart
            if (MedicionGrafica.Series.Count > 0)
            {
                MedicionGrafica.Series[0].Points.Clear();
            }

            // 2. Clear the DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh(); // Optional: Ensures immediate UI update

            // 3. Reset counters
            contadorTiempo = 0;
            contadorMediciones = 0;

            // 4. Re-initialize the chart (optional, if needed)
            InicializarGrafico();

            // 5. Add initial values (if required)
            AgregarNumerosIniciales();

            // 6. Start the BackgroundWorker and Timer
            dataWorker.RunWorkerAsync();
            timer.Start();
        }
        private void DataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simular la generación de datos en segundo plano
            Random rand = new Random();
            while (!dataWorker.CancellationPending && contadorMediciones < 10)
            {
                // Generar un valor de voltaje aleatorio
                double voltaje = rand.Next(3, 7);

                // Actualizar el voltajeActual y el DataGridView en el hilo de la UI
                dataGridView1.Invoke(new Action(() =>
                {
                    voltajeActual = voltaje; // Actualizar el valor para el gráfico
                    GenerarMedicion(voltaje); // Actualizar el DataGridView y la gráfica, y subir a la base de datos
                }));

                // Simular un retardo
                System.Threading.Thread.Sleep(500);
            }

            // Detener el proceso después de 10 mediciones (como en tu condición)
            dataWorker.CancelAsync();
        }

        private void GenerarMedicion(double voltaje)
        {
            // Asegurar que este método se ejecute en el hilo de la UI
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action<double>(GenerarMedicion), voltaje);
                return;
            }
            int estacionID = 1; // Reemplaza con la lógica para obtener el EstacionID correcto
            decimal valorDecimal = Convert.ToDecimal(voltaje);

            Random rnd = new Random();
            int productoIndexDescripcion = rnd.Next(0, productosDescripcion.Count);
            string productoID = "";

            // Obtener el producto seleccionado del ComboBox
            if (cmbProducto.SelectedItem != null)
            {
                productoID = cmbProducto.SelectedItem.ToString();
            }
            else if (listaNoSerieProductos.Count > 0)
            {
                // Si no hay nada seleccionado (raro caso), usar un producto aleatorio de la lista cargada
                int indiceProducto = rnd.Next(0, listaNoSerieProductos.Count);
                productoID = listaNoSerieProductos[indiceProducto];
            }
            else
            {
                Console.WriteLine("Error: No hay productos cargados para la prueba.");
                return;
            }

            double corriente = rnd.Next(8, 12);
            string estado = (voltaje >= 4 && voltaje <= 6) && (corriente >= 9 && corriente <= 11) ? "Aprobado" : "Reprobado";

            // Agregar la medición al DataGridView
            dataGridView1.Rows.Add(productosDescripcion[productoIndexDescripcion], productoID, voltaje, corriente, estado);

            // Agregar el punto a la gráfica
            MedicionGrafica.Series[0].Points.AddXY(contadorTiempo, voltaje);
            contadorTiempo++;

            // Hacer scroll del gráfico si el número de puntos excede MaxPuntos
            if (contadorTiempo > MaxPuntos)
            {
                MedicionGrafica.ChartAreas[0].AxisX.Minimum = contadorTiempo - MaxPuntos;
                MedicionGrafica.ChartAreas[0].AxisX.Maximum = contadorTiempo;
            }

            // Incrementar el contador de mediciones
            contadorMediciones++;

            // Subir la medición a la base de datos utilizando la clase ClsMedicion
            // Llamar al método asíncrono y no esperar su finalización para no bloquear la UI
            gestorMediciones.InsertarMedicion(productoID, estacionID, DateTime.Now, valorDecimal, "V", estado);
        }

        private void DataWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Detener el Timer
            timer.Stop();

            // Habilitar el botón "Iniciar" y deshabilitar el botón "Stop"
            BtnIniciar.Enabled = true;
            BtnStop.Enabled = false;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            bucle = false;
            BtnStop.Enabled = false;
            BtnIniciar.Enabled = true;

            // Detener el BackgroundWorker
            dataWorker.CancelAsync();

            // Detener el Timer
            timer.Stop();
        }

        private void AgregarNumerosIniciales()
        {
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                double voltaje = rand.Next(1, 11); // Genera un número entre 1 y 10
                MedicionGrafica.Series[0].Points.AddXY(i, voltaje);
            }
            contadorTiempo = 10; // Ajustar el contador para continuar desde este punto
        }


        private async void Pruebas_Load(object sender, EventArgs e)
        {
            await CargarProductosParaPrueba();

            // Inicializar el BackgroundWorker
            dataWorker = new BackgroundWorker();
            dataWorker.DoWork += DataWorker_DoWork;
            dataWorker.RunWorkerCompleted += DataWorker_RunWorkerCompleted;
            dataWorker.WorkerSupportsCancellation = true;

            // Inicializar el Timer
            timer = new Timer();
            timer.Interval = 500; // 500 milisegundos = 0.5 segundos
            timer.Tick += Timer_Tick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}