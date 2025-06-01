using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomatizacionPruebasElectricas.Classes;

namespace AutomatizacionPruebasElectricas.Views
{
    public partial class PruebaManual : Form
    {
        private ClsMultiConnection _multimeter;
        private volatile string _receivedValue;
        private TaskCompletionSource<string> _measurementCompletionSource;
        private ClsMedicion gestorMediciones = new ClsMedicion(); // Instancia de la clase ClsMedicion
        private List<string> listaNoSerieProductos = new List<string>();
        private SerialPort _relayPort;
        private CancellationTokenSource _relayCts;
        private string _selectedPort;

        public PruebaManual()
        {
            InitializeComponent();
            InitializeMultimeter();
        }

        private void InitializeMultimeter()
        {
            try
            {
                // Initialize multimeter connection
                _multimeter = new ClsMultiConnection("USB0::0x05E6::0x2110::8015105::INSTR");
                _multimeter.sendValue = ReceiveValue;
                comboBox1.SelectedIndex = 0; // Select first item by default
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing multimeter: {ex.Message}", "Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReceiveValue(string value)
        {
            _receivedValue = value.Trim();
            _measurementCompletionSource?.TrySetResult(_receivedValue);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (_multimeter == null)
            {
                MessageBox.Show("Multimeter not initialized", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            button1.Enabled = false;
            richTextBox1.Text = "Measuring...";

            try
            {
                string measurementType = comboBox1.SelectedItem.ToString();
                string measurementValue = comboBox2.SelectedItem.ToString();
                string result = await TakeMeasurementAsync(measurementType, measurementValue);
                await TakeMeasurementAsync(measurementType, measurementValue);

                richTextBox1.Text = $"{result} {(measurementType == "RESISTENCIA" ? "Ω" : "V")}";
            }
            catch (Exception ex)
            {
                richTextBox1.Text = $"Error: {ex.Message}";
            }
            finally
            {
                button1.Enabled = true;
            }
        }

        private async Task<string> TakeMeasurementAsync(string measurementType, string measurementValue)
        {
            // Set multimeter mode based on selection
            if (measurementType == "RESISTENCIA")
            {

                _multimeter.SetModoResistencia();


                if (measurementValue == "3")
                {
                    _relayPort.Open();
                    TrySendRelay(0);
                    _relayPort.Close();
                }

                if (measurementValue == "5")
                {
                    _relayPort.Open();
                    TrySendRelay(1);
                    _relayPort.Close();
                }

                if (measurementValue == "12")
                {
                    _relayPort.Open();
                    TrySendRelay(1);
                    _relayPort.Close();
                    TrySendRelay(2);

                    _relayPort.Open();
                    TrySendRelay(2);
                    _relayPort.Close();
                }

                if (measurementValue == "-12")
                {
                    _relayPort.Open();
                    TrySendRelay(3);
                    _relayPort.Close();
                }

            }
            else if (measurementType == "VOLTAJE")
            {
                _multimeter.SetModoVoltaje();

                if (measurementValue == "5")
                {
                    _relayPort.Open();
                    TrySendRelay(1);
                    _relayPort.Close();
                }

                if (measurementValue == "12")
                {
                    _relayPort.Open();
                    TrySendRelay(1);
                    _relayPort.Close();
                    TrySendRelay(2);

                    _relayPort.Open();
                    TrySendRelay(2);
                    _relayPort.Close();
                }

                if (measurementValue == "-12")
                {
                    _relayPort.Open();
                    TrySendRelay(3);
                    _relayPort.Close();
                }


            }


            _measurementCompletionSource = new TaskCompletionSource<string>();
            _receivedValue = null;

            // Start measurement
            _multimeter.LeerMedicion();
            double valor = _multimeter.value;

            richTextBox1.Text= valor.ToString();
            _measurementCompletionSource.SetResult(valor.ToString());

            // Wait for result with timeout
            var timeoutTask = Task.Delay(5000); // 5-second timeout
            var completedTask = await Task.WhenAny(_measurementCompletionSource.Task, timeoutTask);

            if (completedTask == timeoutTask)
            {
                throw new TimeoutException("Measurement timed out");
            }

            return await _measurementCompletionSource.Task;
        }

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

        private void PruebaManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clean up resources
            //_multimeter?.Dispose();
        }

        private async void PruebaManual_Load(object sender, EventArgs e)
        {
            _relayPort = new SerialPort("COM3");
            await CargarProductosParaPrueba();

            // Crea el menú de Puertos COM en tu menuStrip1
            var puertosItem = new ToolStripMenuItem("Puertos COM");
            menuStrip1.Items.Add(puertosItem);
            puertosItem.DropDownOpening += (_, __) => RefreshPorts(puertosItem);
            RefreshPorts(puertosItem);

            

            //cmbProducto_SelectedIndexChanged(sender, e);
        }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_relayPort == null) return;
            _relayPort.Open();
            _relayPort.Write("4");
            richTextBox1.Text = "";
            _relayPort.Close();
        }

        private void PruebaManual_FormClosed(object sender, FormClosedEventArgs e)
        {
            _relayPort.Open();
            TrySendRelay(4);
            TrySendRelay(5);
            _relayPort.Close();
        }
    }
}