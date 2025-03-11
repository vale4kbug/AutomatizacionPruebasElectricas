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

namespace AutomatizacionPruebasElectricas
{
    public partial class Pruebas : Form
    {
        public Pruebas()
        {
            InitializeComponent();
        }

        // Variable para controlar el bucle de generación de datos
        private bool bucle = true;

        // Lista de productos para la simulación
        private List<string> productos = new List<string>() { "Producto 1", "Producto 2", "Producto 3", "Producto 4", "Producto 5" };

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

        private void InicializarGrafico()
        {
            // Configurar el área del gráfico
            MedicionGrafica.Series.Clear();

            var serie = new Series("Voltaje")
            {
                ChartType = SeriesChartType.Line
            };
            MedicionGrafica.Series.Add(serie);

            // Configurar el eje X
            MedicionGrafica.ChartAreas[0].AxisX.Title = "Tiempo";
            MedicionGrafica.ChartAreas[0].AxisX.Interval = 1; // Intervalo fijo
            MedicionGrafica.ChartAreas[0].AxisX.Minimum = 0; // Comenzar desde 0
            MedicionGrafica.ChartAreas[0].AxisX.Maximum = MaxPuntos; // Máximo inicial
            MedicionGrafica.ChartAreas[0].AxisX.ScrollBar.Enabled = true;

            // Configurar el eje Y
            MedicionGrafica.ChartAreas[0].AxisY.Title = "Voltaje";

            // Habilitar doble buffer para reducir el parpadeo
            HabilitarDobleBuffer(MedicionGrafica);
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

            // Reiniciar el contador de mediciones
            contadorMediciones = 0;

            // Inicializar el gráfico
            InicializarGrafico();

            // Iniciar el BackgroundWorker
            dataWorker.RunWorkerAsync();

            // Iniciar el Timer
            timer.Start();
        }

        private void DataWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simular la generación de datos en segundo plano
            Random rand = new Random();
            while (!dataWorker.CancellationPending && contadorMediciones < 30)
            {
                // Generar un valor de voltaje aleatorio
                double voltaje = rand.Next(3, 7);

                // Actualizar el voltajeActual y el DataGridView en el hilo de la UI
                dataGridView1.Invoke(new Action(() =>
                {
                    voltajeActual = voltaje; // Actualizar el valor para el gráfico
                    GenerarMedicion(voltaje); // Actualizar el DataGridView y la gráfica
                }));

                // Simular un retardo
                System.Threading.Thread.Sleep(500);
            }

            // Detener el proceso después de 30 mediciones
            dataWorker.CancelAsync();
        }

        private void GenerarMedicion(double voltaje)
        {
            // Asegurar que este método se ejecute en el hilo de la UI
            if (dataGridView1.InvokeRequired)
            {
                dataGridView1.Invoke(new Action(() => GenerarMedicion(voltaje)));
                return;
            }

            Random rnd = new Random();
            int producto = rnd.Next(1, 5);

            double corriente = rnd.Next(8, 12);

            string estado = "";

            if ((voltaje >= 4 && voltaje <= 6) && (corriente >= 9 && corriente <= 11))
            {
                estado = "Aprobado";
            }
            else
            {
                estado = "Reprobado";
            }

            // Agregar la medición al DataGridView
            dataGridView1.Rows.Add(producto, rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString(), productos[producto], voltaje, corriente, estado);

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

        private void Pruebas_Load(object sender, EventArgs e)
        {
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
    }
}