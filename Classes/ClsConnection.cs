using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
	internal class ClsConnection
	{
		MySqlConnection con;
		MySqlCommand cmd;

		public ClsConnection()
		{
			con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
		}
	}
}
