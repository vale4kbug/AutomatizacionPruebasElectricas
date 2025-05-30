using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
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
        // Aquí va la zona de declaraciones de campos
        private SerialPort _relayPort;
        private CancellationTokenSource _relayCts;
        private string _selectedPort;
        private readonly IList<(int A, int B)> _relaySequences = new List<(int, int)>
    {
        (1, 2),
        (3, 4),
        (5, 6),
        // … agrega aquí tantos pares como relés tengas
    };
        private readonly double[] _resistanceGoals = { 13, 13, 72, 220 };
        private readonly double[] _voltageGoals = { 3.3, 5, 12, -12 };
        private int _currentMeasurementIndex = 0;

        private int goalValue = 0; // Add the global goal value variable
        public string ResistenciaOVoltaje = "";
        private ClsMedicion gestorMediciones = new ClsMedicion(); // Instancia de la clase ClsMedicion
        private List<string> listaNoSerieProductos = new List<string>();

        public int contadorTiempoResistencia = 0;
        public int contadorTiempoVoltaje = 0;
        public double _voltageGoal;

        private bool _isCurrentMeasurement = true;
        private Dictionary<string, double> _productSpecs;
        private int _currentGoal;
        private double _resistanceGoal;
        private const int MeasurementInterval = 2000; // 1 second between types

        // Add these to your form class variables
        private bool isMeasuring = false;
        public ClsConnection _connection = new ClsConnection();

        public Pruebas()
        {
            InitializeComponent();
            cls = new ClsMultiConnection("USB0::0x05E6::0x2110::8015105::INSTR");
            cls.sendValue = RecibirValor;

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
        private const int MaxPuntos = 5;

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

        private void InicializarGraficos()
        {
            // Resistencia Chart
            MedicionGrafica.Series.Clear();
            MedicionGrafica.Series.Add(new Series("Resistencia")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Green
            });

            // Voltaje Chart
            graficaVoltaje.Series.Clear();
            graficaVoltaje.Series.Add(new Series("Voltaje")
            {
                ChartType = SeriesChartType.Line,
                Color = Color.Blue
            });

            // Configurar áreas
            ConfigureChartArea(MedicionGrafica.ChartAreas[0], "Ω");
            ConfigureChartArea(graficaVoltaje.ChartAreas[0], "V");
        }
        private void ConfigureChartArea(ChartArea area, string unit)
        {
            area.AxisX.Title = "Tiempo";
            area.AxisX.Interval = 1;
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = MaxPuntos;
            area.AxisX.ScrollBar.Enabled = true;
            area.AxisY.Title = $"Valor ({unit})";
            area.AxisY.StripLines.Clear();
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

        // Update Start Button Click
        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            BtnIniciar.Enabled = false;
            BtnStop.Enabled = true;

            // Reset counters and clear UI
            contadorTiempoResistencia = 0;
            contadorTiempoVoltaje = 0;
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            MedicionGrafica.Series.Clear();
            graficaVoltaje.Series.Clear();

            InicializarGraficos();
            dataWorker.RunWorkerAsync();


            // Abre el puerto y lanza la secuencia de relés
            //if (string.IsNullOrEmpty(_selectedPort))
            //{
            //    MessageBox.Show("Selecciona un puerto COM primero.", "Error");
            //    dataWorker.CancelAsync();
            //    return;
            //}
            _relayPort.PortName = "COM3";
            //_relayCts = new CancellationTokenSource();
            //_ = StartRelaySequenceAsync(_relayCts.Token);
        }

        ClsMultiConnection cls;
        volatile string value = "";

        private void RecibirValor(string value)
        {
            object obj = new object();
            lock (obj)
                this.value = value.Trim();
        }

        private async Task<string> WaitForValueAsync(int timeoutMs)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < timeoutMs)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    string capturedValue = value;
                    value = ""; // Reset after capturing to avoid old values
                    return capturedValue;
                }
                await Task.Delay(100);
            }
            return "0"; // Timeout, handle as needed
        }

        // Update the DataWorker_DoWork calls
        private async void DataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Obtener el productId en el hilo UI antes de empezar
            string productId = string.Empty;
            if (cmbProducto.InvokeRequired)
            {
                cmbProducto.Invoke(new Action(() => {
                    productId = cmbProducto.SelectedValue?.ToString() ?? string.Empty;
                }));
            }
            else
            {
                productId = cmbProducto.SelectedValue?.ToString() ?? string.Empty;
            }

            _relayPort.Close();

            if (dataWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }

            // Reiniciar índice al comenzar nueva secuencia
            _currentMeasurementIndex = 0;


            // PRIMERA MEDICION, RESISTENCIA CON 3.3V (meta 13)
            cls.SetModoResistencia();
            cls.LeerMedicion();
            double resistencia = cls.value;
            await GenerarMedicion("Resistencia", resistencia, dataGridView1, MedicionGrafica, productId);
            Thread.Sleep(MeasurementInterval);

            // SEGUNDA MEDICION, CON 5V (meta 13)
            _relayPort.Open();
            TrySendRelay(1);
            _relayPort.Close();
            cls.SetModoResistencia();
            cls.LeerMedicion();
            resistencia = cls.value;
            await GenerarMedicion("Resistencia", resistencia, dataGridView1, MedicionGrafica, productId);
            Thread.Sleep(MeasurementInterval);

            // TERCERA MEDICION, CON 12V (meta 72)
            _relayPort.Open();
            TrySendRelay(2);
            _relayPort.Close();
            cls.SetModoResistencia();
            cls.LeerMedicion();
            resistencia = cls.value;
            await GenerarMedicion("Resistencia", resistencia, dataGridView1, MedicionGrafica, productId);
            Thread.Sleep(MeasurementInterval);

            // CUARTA MEDICION, CON -12V (meta 220)
            _relayPort.Open();
            TrySendRelay(1);
            _relayPort.Close();
            _relayPort.Open();
            TrySendRelay(2);
            _relayPort.Close();
            _relayPort.Open();
            TrySendRelay(3);
            _relayPort.Close();
            cls.SetModoResistencia();
            cls.LeerMedicion();
            resistencia = cls.value;
            await GenerarMedicion("Resistencia", resistencia, dataGridView1, MedicionGrafica, productId);
            Thread.Sleep(MeasurementInterval);

            // Apagamos relays y comenzamos mediciones de voltaje
            _relayPort.Open();
            TrySendRelay(3);
            _relayPort.Close();
            _relayPort.Open();
            TrySendRelay(4);
            _relayPort.Close();
            _currentMeasurementIndex = 0; // Reiniciar índice para voltajes


            // PRIMERA MEDICION, RESISTENCIA CON 3.3V (meta 13)
            cls.SetModoVoltaje();
            cls.LeerMedicion();
            double vl = cls.value;
            await GenerarMedicion("Voltaje", vl, dataGridView2, graficaVoltaje, productId);
            Thread.Sleep(MeasurementInterval);

            // SEGUNDA MEDICION, CON 5V (meta 13)
            _relayPort.Open();
            TrySendRelay(1);
            _relayPort.Close();
            cls.SetModoVoltaje();
            cls.LeerMedicion();
            vl = cls.value;
            await GenerarMedicion("Voltaje", vl, dataGridView2, graficaVoltaje, productId);
            Thread.Sleep(MeasurementInterval);

            // TERCERA MEDICION, CON 12V (meta 72)
            _relayPort.Open();
            TrySendRelay(2);
            _relayPort.Close();
            cls.SetModoVoltaje();
            cls.LeerMedicion();
            vl = cls.value;
            await GenerarMedicion("Voltaje", vl, dataGridView2, graficaVoltaje, productId);
            Thread.Sleep(MeasurementInterval);

            // CUARTA MEDICION, CON -12V (meta 220)
            _relayPort.Open();
            TrySendRelay(1);
            _relayPort.Close();
            _relayPort.Open();
            TrySendRelay(2);
            _relayPort.Close();
            _relayPort.Open();
            TrySendRelay(3);
            _relayPort.Close();
            cls.SetModoVoltaje();
            cls.LeerMedicion();
            vl = cls.value;
            await GenerarMedicion("Voltaje", vl, dataGridView2, graficaVoltaje, productId);
            Thread.Sleep(MeasurementInterval);

            // Apagamos relays y comenzamos mediciones de voltaje
            _relayPort.Open();
            TrySendRelay(3);
            _relayPort.Close();
            _relayPort.Open();
            TrySendRelay(4);
            _relayPort.Close();
            _currentMeasurementIndex = 0; // Reiniciar índice para voltajes


        }

        private async Task GenerarMedicion(string tipo, double valor, DataGridView grid, Chart chart, string productId)
        {
            // Obtener el valor meta actual basado en el índice
            double goal = tipo == "Resistencia" ? _resistanceGoals[_currentMeasurementIndex]
                                               : _voltageGoals[_currentMeasurementIndex];

            string unidad = tipo == "Resistencia" ? "Ω" : "V";

            // Calcular estado (con márgenes diferentes para resistencia y voltaje)
            double margin = tipo == "Resistencia" ? goal * 0.1 : 0.2; // 10% para resistencia, 0.2V para voltaje
            string estado = (valor >= goal - margin && valor <= goal + margin)
                           ? "Aprobado" : "Reprobado";

            // Agregar a DataGridView (usar Invoke si es necesario)
            if (grid.InvokeRequired)
            {
                grid.Invoke(new Action(() =>
                {
                    grid.Rows.Add(tipo, $"{valor:F2}", $"{goal:F2}", estado);
                }));
            }
            else
            {
                grid.Rows.Add(tipo, $"{valor:F2}", $"{goal:F2}", estado);
            }

            // Actualizar gráfica (siempre debe ejecutarse en el hilo UI)
            if (chart.InvokeRequired)
            {
                chart.Invoke(new Action(() => UpdateChart(tipo, valor, goal, chart)));
            }
            else
            {
                UpdateChart(tipo, valor, goal, chart);
            }

            // Insertar en base de datos
            await gestorMediciones.InsertarMedicion(
                productId,
                1, // Station ID
                DateTime.Now,
                valor,
                unidad,
                estado
            );

            // Incrementar índice para la próxima medición
            _currentMeasurementIndex = (_currentMeasurementIndex + 1) % _resistanceGoals.Length;
        }
        private void DataWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Detener el Timer
            timer.Stop();

            // Habilitar el botón "Iniciar" y deshabilitar el botón "Stop"
            BtnIniciar.Enabled = true;
            BtnStop.Enabled = false;

            _relayCts?.Cancel();
            if (_relayPort.IsOpen)
                _relayPort.Close();

        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            // — Detiene medición —
            dataWorker.CancelAsync();
            timer.Stop();

            // — Detiene relés —
            if (_relayCts != null)
            {
                _relayCts.Cancel();
                _relayCts.Dispose();
                _relayCts = null;
            }
            if (_relayPort.IsOpen)
                _relayPort.Close();

            BtnStop.Enabled = false;
            BtnIniciar.Enabled = true;
        }

        //private void AgregarNumerosIniciales()
        //{
        //    Random rand = new Random();
        //    for (int i = 0; i < 20; i++)
        //    {
        //        double corriente = rand.Next(_currentGoal - 2, _currentGoal + 2);
        //        double resistencia = rand.Next(_resistanceGoal - 5, _resistanceGoal + 5);

        //        MedicionGrafica.Series["Corriente"].Points.AddXY(i, corriente);
        //        MedicionGrafica.Series["Resistencia"].Points.AddXY(i, resistencia);
        //    }
        //    contadorTiempo = 20; // Ajustar el contador para continuar desde este punto
        //}

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


        private void RefreshPorts(ToolStripMenuItem puertosItem)
        {
            puertosItem.DropDownItems.Clear();
            var ports = SerialPort.GetPortNames();
            if (ports.Length == 0)
            {
                puertosItem.DropDownItems.Add("— No se encontraron —").Enabled = false;
                _selectedPort = null;
                return;
            }
            foreach (var p in ports)
            {
                var it = new ToolStripMenuItem(p);
                it.Click += (_, __) =>
                {
                    foreach (ToolStripMenuItem mi in puertosItem.DropDownItems)
                        mi.Checked = false;
                    it.Checked = true;
                    _selectedPort = p;
                };
                puertosItem.DropDownItems.Add(it);
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

            // Prepara el puerto (sin abrirlo aún)
            _relayPort = new SerialPort
            {
                BaudRate = 9600,
                ReadTimeout = 500,
                WriteTimeout = 500
            };

            // Crea el menú de Puertos COM en tu menuStrip1
            var puertosItem = new ToolStripMenuItem("Puertos COM");
            menuStrip1.Items.Add(puertosItem);
            puertosItem.DropDownOpening += (_, __) => RefreshPorts(puertosItem);
            RefreshPorts(puertosItem);
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

                foreach (var v in _productSpecs)
                {
                    if (v.Key == "Resistencia")
                    {
                        double.TryParse(v.Value.ToString(), out _resistanceGoal);
                    }
                    if (v.Key == "Voltaje")
                    {
                        double.TryParse(v.Value.ToString(), out _voltageGoal);
                    }
                }

               // UpdateGoalLines();
                lblProductName.Text = $"Meta Resistencia: {_resistanceGoal}Ω | Meta Voltaje: {_voltageGoal}V";
               // UpdateGoalLines();  // Add this line

                //if (_productSpecs.TryGetValue("Resistencia", out _resistanceGoal) ||
                //    _productSpecs.TryGetValue("Voltaje", out _voltageGoal))
                //{
                //    UpdateGoalLines();
                //    lblProductName.Text = $"Meta Resistencia: {_resistanceGoal}Ω | Meta Voltaje: {_voltageGoal}V";
                //    UpdateGoalLines();  // Add this line
                //}
            }
        }

        private void UpdateChart(string tipo, double valor, double goal, Chart chart)
        {
            var series = chart.Series[0];
            int counter = tipo == "Resistencia" ? contadorTiempoResistencia++ : contadorTiempoVoltaje++;

            // Agregar punto de medición
            series.Points.AddXY(counter, valor);

            // Agregar punto de meta (en una serie diferente)
            if (chart.Series.Count < 2)
            {
                var goalSeries = new Series(tipo + " Meta")
                {
                    ChartType = SeriesChartType.Line,
                    Color = tipo == "Resistencia" ? Color.DarkGreen : Color.DarkBlue,
                    BorderWidth = 2,
                    BorderDashStyle = ChartDashStyle.Dash
                };
                chart.Series.Add(goalSeries);
            }

            chart.Series[1].Points.AddXY(counter, goal);

            // Ajustar vista
            if (counter > MaxPuntos)
            {
                chart.ChartAreas[0].AxisX.Minimum = counter - MaxPuntos;
                chart.ChartAreas[0].AxisX.Maximum = counter;
            }

            // Ajustar eje Y automáticamente
            chart.ChartAreas[0].AxisY.Minimum = double.NaN;
            chart.ChartAreas[0].AxisY.Maximum = double.NaN;
        }


        /// <summary>
        /// Ejecuta en bucle la secuencia de pares de relés,
        /// enviando A y B y esperando 1 s entre cada paso.
        /// </summary>
        private async Task StartRelaySequenceAsync(CancellationToken ct)
        {
            int idx = 0;
            while (!ct.IsCancellationRequested)
            {
                var (A, B) = _relaySequences[idx];

                TrySendRelay(A);
                TrySendRelay(B);

                idx = (idx + 1) % _relaySequences.Count;

                try
                {
                    await Task.Delay(1000, ct);
                }
                catch (TaskCanceledException)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Envía por el puerto serie el número de relé n.
        /// </summary>
        private void TrySendRelay(int n)
        {
            if (_relayPort.IsOpen)
            {
                try
                {
                    _relayPort.WriteLine(n.ToString());
                }
                catch
                {
                    // opcional: registrar/loguear el error
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}