using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsConnection
	{
		MySqlConnection con;
		MySqlCommand cmd;
		MySqlDataAdapter adapter;
		MySqlDataReader reader;

		public ClsConnection()
		{
			con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
			cmd = con.CreateCommand();
		}

		//Esta funcion devuelve un unico valor de la base de datos, segun el query que mandes
		protected async Task<string> GetUniqueValue(string query)
		{
			string value = "";
			cmd.CommandText = query;
			try
			{
				await OpenConnection();
				var obj = await cmd.ExecuteScalarAsync();

				value = obj.ToString();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch(NullReferenceException)
			{
				value = null;
			}
			finally
			{
				await CloseConnection();
			}
			return value;
		}


		//Metodo para abrir conexion a base de datos
		private async Task<MySqlConnection> OpenConnection()
		{
			await con.OpenAsync();
			return con;
		}

		//Metodo para cerrar conexion a base de datos
		private async Task CloseConnection()
		{
			await con.CloseAsync();
		}
	}
}
