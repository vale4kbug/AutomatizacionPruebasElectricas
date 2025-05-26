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


        private int goalValue = 0; // Add the global goal value variable
        public string ResistenciaOVoltaje = "";
        private ClsMedicion gestorMediciones = new ClsMedicion(); // Instancia de la clase ClsMedicion
        private List<string> listaNoSerieProductos = new List<string>();

		public int contadorTiempoResistencia = 0;
		public int contadorTiempoVoltaje = 0;
		public int _voltageGoal;

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

		// Modified Initialize Charts
		private void InicializarGraficos()
		{
			// Resistance Chart
			MedicionGrafica.Series.Clear();
			var serieResistencia = new Series("Resistencia")
			{
				ChartType = SeriesChartType.Line,
				Color = Color.Green
			};
			MedicionGrafica.Series.Add(serieResistencia);

			// Voltage Chart
			graficaVoltaje.Series.Clear();
			var serieVoltaje = new Series("Voltaje")
			{
				ChartType = SeriesChartType.Line,
				Color = Color.Blue
			};
			graficaVoltaje.Series.Add(serieVoltaje);

			// Configure chart areas
			ConfigureChartArea(MedicionGrafica.ChartAreas[0], "Ω");
			ConfigureChartArea(graficaVoltaje.ChartAreas[0], "V");

			UpdateGoalLines();  // Add this line
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
			MedicionGrafica.Series[0].Points.Clear();
			graficaVoltaje.Series[0].Points.Clear();

			InicializarGraficos();
			dataWorker.RunWorkerAsync();

            // Abre el puerto y lanza la secuencia de relés
            if (string.IsNullOrEmpty(_selectedPort))
            {
                MessageBox.Show("Selecciona un puerto COM primero.", "Error");
                return;
            }
            _relayPort.PortName = _selectedPort;
            if (!_relayPort.IsOpen) _relayPort.Open();
            _relayCts = new CancellationTokenSource();
            _ = StartRelaySequenceAsync(_relayCts.Token);
        }


		// Update the DataWorker_DoWork calls
		private void DataWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			Random rand = new Random();

			// Resistance Phase (10 measurements)
			for (int i = 0; i < 20; i++)
			{
				if (dataWorker.CancellationPending)
				{
					e.Cancel = true;
					return;
				}

				double resistencia = rand.Next(_resistanceGoal - 5, _resistanceGoal + 5);

				dataGridView1.Invoke(new Action(() =>
				{
					GenerarMedicion("Resistencia", resistencia, dataGridView1, MedicionGrafica);
				}));

				Thread.Sleep(MeasurementInterval);
			}

			Thread.Sleep(1000); // Pause between phases

			// Voltage Phase (10 measurements)
			for (int i = 0; i < 20; i++)
			{
				if (dataWorker.CancellationPending)
				{
					e.Cancel = true;
					return;
				}

				double voltaje = rand.Next(_voltageGoal - 2, _voltageGoal + 2);

				dataGridView2.Invoke(new Action(() =>
				{
					GenerarMedicion("Voltaje", voltaje, dataGridView2, graficaVoltaje);
				}));

				Thread.Sleep(MeasurementInterval);
			}
		}


		// Change the method signature to remove the ref parameter
		private async void GenerarMedicion(string tipo, double valor, DataGridView grid, Chart chart)
		{
			// Determine goal and unit based on measurement type
			int goal = tipo == "Resistencia" ? _resistanceGoal : _voltageGoal;
			string unidad = tipo == "Resistencia" ? "Ω" : "V";

			// Calculate status
			string estado = (valor >= goal - (tipo == "Resistencia" ? 5 : 2) &&
						   valor <= goal + (tipo == "Resistencia" ? 5 : 2))
						   ? "Aprobado" : "Reprobado";

			// Add to DataGridView with explicit goal value
			grid.Rows.Add(tipo, valor, goal, estado);

			// Get and update appropriate counter
			int counter = tipo == "Resistencia" ? contadorTiempoResistencia++ : contadorTiempoVoltaje++;

			// Chart update
			var series = chart.Series[0];
			series.Points.AddXY(counter, valor);

			// Handle chart scrolling
			if (counter > MaxPuntos)
			{
				chart.ChartAreas[0].AxisX.Minimum = counter - MaxPuntos;
				chart.ChartAreas[0].AxisX.Maximum = counter;
			}

			// Database insertion
			await gestorMediciones.InsertarMedicion(
				cmbProducto.SelectedValue.ToString(),
				1, // Station ID
				DateTime.Now,
				Convert.ToDecimal(valor),
				unidad,
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

        private void AgregarNumerosIniciales()
        {
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                double corriente = rand.Next(_currentGoal - 2, _currentGoal + 2);
                double resistencia = rand.Next(_resistanceGoal - 5, _resistanceGoal + 5);

                MedicionGrafica.Series["Corriente"].Points.AddXY(i, corriente);
                MedicionGrafica.Series["Resistencia"].Points.AddXY(i, resistencia);
            }
            contadorTiempo = 20; // Ajustar el contador para continuar desde este punto
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

				if (_productSpecs.TryGetValue("Resistencia", out _resistanceGoal) &&
					_productSpecs.TryGetValue("Voltaje", out _voltageGoal))
				{
					UpdateGoalLines();
					lblProductName.Text = $"Meta Resistencia: {_resistanceGoal}Ω | Meta Voltaje: {_voltageGoal}V";
					UpdateGoalLines();  // Add this line
				}
			}
		}

		private void UpdateGoalLines()
		{
			// Update both charts
			UpdateChartGoalLine(MedicionGrafica, _resistanceGoal, Color.Green, "Resistencia");
			UpdateChartGoalLine(graficaVoltaje, _voltageGoal, Color.Blue, "Voltaje");

			// Refresh charts
			MedicionGrafica.Invalidate();
			graficaVoltaje.Invalidate();
		}
		private void UpdateChartGoalLine(Chart chart, int goal, Color color, string measurementType)
		{
			chart.ChartAreas[0].AxisY.StripLines.Clear();

			StripLine goalLine = new StripLine
			{
				IntervalOffset = goal,
				StripWidth = 0.1,  // Thin line width
				BackColor = Color.Transparent,  // No fill
				BorderColor = color,
				BorderWidth = 2,
				BorderDashStyle = ChartDashStyle.Solid,  // Solid line
				ToolTip = $"Meta {measurementType}: {goal}{(measurementType == "Resistencia" ? "Ω" : "V")}"
			};

			chart.ChartAreas[0].AxisY.StripLines.Add(goalLine);

			// Ensure the goal line remains visible in the chart
			double buffer = measurementType == "Resistencia" ? 10 : 5;
			var axis = chart.ChartAreas[0].AxisY;
			axis.Minimum = Math.Min(goal - buffer, axis.Minimum);
			axis.Maximum = Math.Max(goal + buffer, axis.Maximum);
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