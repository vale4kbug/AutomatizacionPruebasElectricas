using System;
using System.Threading;
using System.Threading.Tasks;
using Ivi.Visa;
using NationalInstruments.Visa;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsMultiConnection
    {
        private string deviceAddress;
        public Action<string> sendValue;

        public double value;

        public ClsMultiConnection(string devideAddress)
        {
            this.deviceAddress = devideAddress;
            value = 0.0;
        }

        public void SetModoVoltaje()
        {
            try
            {
                ResourceManager rm = new ResourceManager();
                using (MessageBasedSession session = (MessageBasedSession)rm.Open(deviceAddress))
                {
                    session.RawIO.Write("*RST");                  // Reiniciar dispositivo
                    session.RawIO.Write("CONF:VOLT:DC 10");       // Configurar para voltaje DC hasta 10V
                }
            }
            catch (VisaException ex) 
            {
                sendValue($"Error al configurar modo voltaje: {ex.Message}");
            }
        }

        public void SetModoResistencia()
        {
            try
            {
                ResourceManager rm = new ResourceManager();
                using (MessageBasedSession session = (MessageBasedSession)rm.Open(deviceAddress))
                {
 
                    session.RawIO.Write("*RST");              // Reiniciar dispositivo
                    session.RawIO.Write("CONF:RES AUTO");     // Configurar para medir resistencia con rango automático
                }
            }
            catch (VisaException ex)
            {
                sendValue($"Error al configurar modo resistencia: {ex.Message}");
            }
        }

        public void LeerMedicion()
        {
            string response = "";
            try
            {
                ResourceManager rm = new ResourceManager();
                using (MessageBasedSession session = (MessageBasedSession)rm.Open(deviceAddress))
                {
                    Thread.Sleep(500);
                    //session.RawIO.Write("INIT");      // Iniciar medición
                    session.RawIO.Write("READ?");     // Leer resultado
                    response = session.RawIO.ReadString();
                    value = double.Parse(response);
                    //sendValue?.Invoke($"{response}");
                }
            }
            catch (VisaException ex)
            {
                Console.WriteLine($"Error al leer medición: {ex.Message}");
            }
        }
    }
}
