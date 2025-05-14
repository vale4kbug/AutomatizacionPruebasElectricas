using System;
using Ivi.Visa;
using NationalInstruments.Visa;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsMultiConnection
	{
		private string deviceAddress;
		public Action<string> sendValue;

		public ClsMultiConnection(string devideAddress)
		{
			this.deviceAddress = devideAddress;
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
					sendValue?.Invoke("Modo configurado: Voltaje DC");
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
			try
			{
				ResourceManager rm = new ResourceManager();
				using (MessageBasedSession session = (MessageBasedSession)rm.Open(deviceAddress))
				{
					session.RawIO.Write("INIT");      // Iniciar medición
					session.RawIO.Write("READ?");     // Leer resultado
					string response = session.RawIO.ReadString();

					sendValue?.Invoke($"{response}");
				}
			}
			catch (VisaException ex)
			{
				Console.WriteLine($"Error al leer medición: {ex.Message}");
			}
		}
	}
}
