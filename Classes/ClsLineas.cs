using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsLineas : ClsConnection
	{

		public Action<DataTable> sendDatos;

		public async Task GetLinea(string id)
		{
			var result = await GetTable("select * from lineasproduccion");

			sendDatos?.Invoke(result);
		}
	}
}
