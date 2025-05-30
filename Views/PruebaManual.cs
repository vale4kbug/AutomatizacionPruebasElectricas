using System;
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
                string result = await TakeMeasurementAsync(measurementType);

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

        private async Task<string> TakeMeasurementAsync(string measurementType)
        {
            // Set multimeter mode based on selection
            if (measurementType == "RESISTENCIA")
            {
                _multimeter.SetModoResistencia();
            }
            else if (measurementType == "VOLTAJE")
            {
                _multimeter.SetModoVoltaje();
            }

            _measurementCompletionSource = new TaskCompletionSource<string>();
            _receivedValue = null;

            // Start measurement
            _multimeter.LeerMedicion();

            // Wait for result with timeout
            var timeoutTask = Task.Delay(5000); // 5-second timeout
            var completedTask = await Task.WhenAny(_measurementCompletionSource.Task, timeoutTask);

            if (completedTask == timeoutTask)
            {
                throw new TimeoutException("Measurement timed out");
            }

            return await _measurementCompletionSource.Task;
        }

        private void PruebaManual_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clean up resources
            //_multimeter?.Dispose();
        }
    }
}