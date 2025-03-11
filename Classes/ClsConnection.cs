using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsConnection
	{
		readonly protected MySqlConnection con;
		readonly protected MySqlCommand cmd;
		protected MySqlDataAdapter adapter;
		readonly protected MySqlDataReader reader;

		public ClsConnection()
		{
			con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
			cmd = con.CreateCommand();
		}


		//Esta funcion regresa un datatable de acuerdo al query
		protected async Task<DataTable> GetTable(string query)
		{
			DataTable result = new DataTable();
			try
			{
				adapter = new MySqlDataAdapter(query, await OpenConnection());
				await adapter.FillAsync(result);
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				await CloseConnection();
			}

			return result;
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
                if (obj == null || obj == DBNull.Value)
                {
                    obj = "xd";  // Leave it blank if obj is null or DBNull
                }
                value = obj.ToString();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			catch (NullReferenceException)
			{
				value = null;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			try
			{
				await con.OpenAsync();
			}
			catch (Exception)
			{
				throw new Exception("Error al conectarse a la base de datos");
			}
			return con;
		}

		//Metodo para cerrar conexion a base de datos
		private async Task CloseConnection()
		{
			await con.CloseAsync();
		}
	}
}
