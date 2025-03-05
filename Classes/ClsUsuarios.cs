using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsUsuarios : ClsConnection
	{
		public Action<DataTable> sendDatos;

		public async Task GetUser(string id)
		{
			DataTable datosUsuario = await GetTable("select Nombre, Apellido, FechaContratacion, FotoRuta, Username, Contraseña " +
				$"from usuarios where IDUsuario = {id}");

			sendDatos(datosUsuario);
		}
	}
}
