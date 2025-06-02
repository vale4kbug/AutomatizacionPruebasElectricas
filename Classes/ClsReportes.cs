using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsReportes : ClsConnection
	{
		public async Task<DataTable> ReporteDeEstadisticasPromedioDeResistenciaDeProducto(string NoSerie, DateTime fechaA, DateTime fechaB)
		{
			return await GetProcedure("ObtenerEstadisticasPromedioDeResistenciaDeProducto", NoSerie, fechaA, fechaB);
		}

		public async Task<DataTable> ReporteDeEstadisticasPromedioDeVoltajesDeProducto(string NoSerie, DateTime fechaA, DateTime fechaB)
		{
			return await GetProcedure("ObtenerEstadisticasPromedioDeVoltajesDeProducto", NoSerie, fechaA, fechaB);
		}
	}
}
