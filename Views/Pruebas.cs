using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AutomatizacionPruebasElectricas.Classes;
using iTextSharp.text.pdf.security;
using MySql.Data.MySqlClient;

namespace AutomatizacionPruebasElectricas
{
    public partial class Pruebas : Form
    {
        private int goalValue = 0; // Add the global goal value variable
        public string ResistenciaOVoltaje = "";
        private ClsMedicion gestorMediciones = new ClsMedicion(); // Instancia de la clase ClsMedicion
        private List<string> listaNoSerieProductos = new List<string>();

        private bool _isCurrentMeasurement = true;
        private Dictionary<string, int> _productSpecs;
        private int _currentGoal;
        private int _resistanceGoal;
        private const int MeasurementInterval = 1000; // 1 second between types

        // Add these to your form class variables
        private bool isMeasuring = false;
        public ClsConnection _connection = new ClsConnection();

        public Pruebas()
        {
            InitializeComponent();

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Make MedicionGrafica fill the left half of groupBox1
            dataGridView1.Columns.Add("colTipo", "Tipo de Medicion");
            dataGridView1.Columns.Add("colValor", "Valor Medido");
            dataGridView1.Columns.Add("colMeta", "Valor Meta");
            dataGridView1.Columns.Add("colEstado", "Estado");

            dataGridView2.Columns.Add("colTipo", "Tipo de Medicion");
            dataGridView2.Columns.Add("colValor", "Valor Medido");
            dataGridView2.Columns.Add("colMeta", "Valor Meta");
            dataGridView2.Columns.Add("colEstado", "Estado");

            // Anchor labels so they stay near their intended positions
            lblProductName.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            //lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;

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

        // Timer para actualizar el gráfico
        private System.Windows.Forms.Timer timer;

        // Número máximo de puntos a mostrar antes de hacer scroll
        private const int MaxPuntos = 30;

        // Contador para el eje X (tiempo)
        private int contadorTiempo = 0;

        // Contador para el número de mediciones generadas
        private int contadorMediciones = 0;

        private async Task CargarProductosParaPrueba()
        {
            DataTable tablaProductos = await gestorMediciones.ObtenerNoSerieProductos();

            if (tablaProductos != null)
            {
                listaNoSerieProductos.Clear(); // Limpiar la lista anterior
                cmbProducto.Items.Clear();     // Limpiar los items del ComboBox

                cmbProducto.DataSource = tablaProductos;
                cmbProducto.ValueMember = "NoSerie";
                cmbProducto.DisplayMember = "Descripcion";

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
            MedicionGrafica.Series.Clear();

            // Current series
            var serieCorriente = new Series("Corriente")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue
            };

            // Resistance series
            var serieResistencia = new Series("Resistencia")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green
            };

            MedicionGrafica.Series.Add(serieCorriente);
            MedicionGrafica.Series.Add(serieResistencia);

            // Configure chart area
            var chartArea = MedicionGrafica.ChartAreas[0];
            chartArea.AxisX.Title = "Tiempo";
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = MaxPuntos;
            chartArea.AxisX.ScrollBar.Enabled = true;
            chartArea.AxisY.Title = "Valor";

            // Add goal lines
            UpdateGoalLines();
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
            // Chart updates are now handled in GenerarMedicion
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            BtnIniciar.Enabled = false;
            BtnStop.Enabled = true;
            bucle = true;

            // 1. Clear the Chart
            MedicionGrafica.Series.Clear();
            InicializarGrafico();

            // 2. Clear the DataGridView
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            // 3. Reset counters
            contadorTiempo = 0;
            contadorMediciones = 0;

            // 4. Start the BackgroundWorker and Timer
            dataWorker.RunWorkerAsync();
            timer.Start();
        }

        private void DataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Random rand = new Random();
            while (!dataWorker.CancellationPending && contadorMediciones < 10)
            {
                // Generate values for both types
                double corriente = rand.Next(_currentGoal - 2, _currentGoal + 2);
                double resistencia = rand.Next(_resistanceGoal - 5, _resistanceGoal + 5);

                dataGridView1.Invoke(new Action(() =>
                {
                    // Current measurement
                    GenerarMedicion("Corriente", corriente);

                    // Resistance measurement
                    GenerarMedicion("Resistencia", resistencia);

                    contadorMediciones++;
                }));

                Thread.Sleep(500);
            }
        }

        private void GenerarMedicion(string tipo, double valor)
        {
            // Asegurar que este método se ejecute en el hilo de la UI
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action<string, double>(GenerarMedicion), tipo, valor);
                return;
            }

            int estacionID = 1; // Reemplaza con la lógica para obtener el EstacionID correcto
            string productoID = "";

            // Obtener el producto seleccionado del ComboBox
            if (cmbProducto.SelectedItem != null)
            {
                productoID = cmbProducto.SelectedValue.ToString();
            }
            else if (listaNoSerieProductos.Count > 0)
            {
                // Si no hay nada seleccionado (raro caso), usar un producto aleatorio de la lista cargada
                Random rnd = new Random();
                int indiceProducto = rnd.Next(0, listaNoSerieProductos.Count);
                productoID = listaNoSerieProductos[indiceProducto];
            }
            else
            {
                Console.WriteLine("Error: No hay productos cargados para la prueba.");
                return;
            }

            string estado = (valor >= (tipo == "Corriente" ? _currentGoal - 1 : _resistanceGoal - 2) &&
                           valor <= (tipo == "Corriente" ? _currentGoal + 1 : _resistanceGoal + 2))
                           ? "Aprobado" : "Reprobado";

            // Agregar la medición al DataGridView
            dataGridView1.Rows.Add(tipo, valor, tipo == "Corriente" ? _currentGoal : _resistanceGoal, estado);

            // Add to chart with type-specific series
            var series = tipo == "Corriente" ?
                MedicionGrafica.Series["Corriente"] :
                MedicionGrafica.Series["Resistencia"];

            series.Points.AddXY(contadorTiempo, valor);
            contadorTiempo++;

            // Hacer scroll del gráfico si el número de puntos excede MaxPuntos
            if (contadorTiempo > MaxPuntos)
            {
                MedicionGrafica.ChartAreas[0].AxisX.Minimum = contadorTiempo - MaxPuntos;
                MedicionGrafica.ChartAreas[0].AxisX.Maximum = contadorTiempo;
            }

            // Insertar en la base de datos
            gestorMediciones.InsertarMedicion(
                productoID,
                estacionID,
                DateTime.Now,
                Convert.ToDecimal(valor),
                tipo == "Corriente" ? "A" : "Ω",
                estado
            );
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
                double corriente = rand.Next(_currentGoal - 2, _currentGoal + 2);
                double resistencia = rand.Next(_resistanceGoal - 5, _resistanceGoal + 5);

                MedicionGrafica.Series["Corriente"].Points.AddXY(i, corriente);
                MedicionGrafica.Series["Resistencia"].Points.AddXY(i, resistencia);
            }
            contadorTiempo = 10; // Ajustar el contador para continuar desde este punto
        }

        private async void CargarComboboxLineas()
        {
            try
            {
                DataTable dtLineas = await gestorMediciones.GetLineasProduccion();

                cmbLinea.DisplayMember = "Nombre";
                cmbLinea.ValueMember = "LineaID";
                cmbLinea.DataSource = dtLineas;

                // Add default empty item
                DataRow emptyRow = dtLineas.NewRow();
                emptyRow["Nombre"] = "-- Seleccione línea --";
                emptyRow["LineaID"] = 0;
                dtLineas.Rows.InsertAt(emptyRow, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando líneas: {ex.Message}");
            }
        }

        private async void Pruebas_Load(object sender, EventArgs e)
        {
            await CargarProductosParaPrueba();
            CargarComboboxLineas();

            // Add this line to handle product selection changes
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;

            // Rest of your existing code...
            dataWorker = new BackgroundWorker();
            dataWorker.DoWork += DataWorker_DoWork;
            dataWorker.RunWorkerCompleted += DataWorker_RunWorkerCompleted;
            dataWorker.WorkerSupportsCancellation = true;

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Your existing code
        }

        private async void cmbLinea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLinea.SelectedValue == null || cmbLinea.SelectedValue.ToString() == "0")
            {
                cmbEstacion.DataSource = null;
                return;
            }

            int lineaID = (int)cmbLinea.SelectedValue;
            await CargarComboboxEstaciones(lineaID);
        }

        private async Task CargarComboboxEstaciones(int lineaID)
        {
            try
            {
                DataTable dtEstaciones = await gestorMediciones.GetEstacionesPrueba(lineaID);

                cmbEstacion.DisplayMember = "Nombre";
                cmbEstacion.ValueMember = "EstacionID";
                cmbEstacion.DataSource = dtEstaciones;

                // Add default empty item
                DataRow emptyRow = dtEstaciones.NewRow();
                emptyRow["Nombre"] = "-- Seleccione estación --";
                emptyRow["EstacionID"] = 0;
                dtEstaciones.Rows.InsertAt(emptyRow, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando estaciones: {ex.Message}");
            }
        }

        private async void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cmbProducto.SelectedValue?.ToString(), out int productId))
            {
                _productSpecs = await gestorMediciones.GetEspecificacionesProducto(productId);

                if (_productSpecs.TryGetValue("Corriente", out _currentGoal) &&
                    _productSpecs.TryGetValue("Resistencia", out _resistanceGoal))
                {
                    UpdateGoalLines();
                    lblProductName.Text = $"Meta Corriente: {_currentGoal}A";
                //    lblResult.Text = $"Meta Resistencia: {_resistanceGoal}Ω";
                }
            }
        }

        private void UpdateGoalLines()
        {
            var chartArea = MedicionGrafica.ChartAreas[0];
            chartArea.AxisY.StripLines.Clear();

            // Current goal line
            chartArea.AxisY.StripLines.Add(new StripLine
            {
                IntervalOffset = _currentGoal,
                StripWidth = 0.1,
                BackColor = Color.Blue,
                ToolTip = $"Meta Corriente: {_currentGoal}A"
            });

            // Resistance goal line
            chartArea.AxisY.StripLines.Add(new StripLine
            {
                IntervalOffset = _resistanceGoal,
                StripWidth = 0.1,
                BackColor = Color.Green,
                ToolTip = $"Meta Resistencia: {_resistanceGoal}Ω"
            });
        }

        private void UpdateGoalLineInChart()
        {
            if (MedicionGrafica.ChartAreas.Count > 0)
            {
                var chartArea = MedicionGrafica.ChartAreas[0];
                chartArea.AxisY.StripLines.Clear();

                // Add new goal lines
                UpdateGoalLines();
            }
        }
    }
}