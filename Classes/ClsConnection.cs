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
	public abstract class ClsConnection
	{
		readonly protected MySqlConnection con;
		readonly protected MySqlCommand cmd;
		protected MySqlDataAdapter adapter;
		readonly protected MySqlDataReader reader;

		public ClsConnection()
		{
			try
			{
				con = new MySqlConnection(ConfigurationManager.ConnectionStrings["con"].ToString());
				cmd = con.CreateCommand();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error al cargar la configuración de la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Metodo para abrir conexion a base de datos
		protected async Task<bool> OpenConnection()
		{
			try
			{
				if (con.State == ConnectionState.Closed)
				{
					await con.OpenAsync();
				}
				return true;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("No se pudo conectar con el servidor de base de datos.\nVerifica tu conexión a internet o el estado del servidor.\n\n" + ex.Message,
								"Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		//Metodo para cerrar conexion a base de datos
		protected async Task CloseConnection()
		{
			if (con.State == ConnectionState.Open)
			{
				await con.CloseAsync();
			}
		}

		//Esta funcion es para ejecutar querys que no regresan nada, por ejemplo Inserts, Deletes, Updates
		protected async Task<int> PutInDatabase(string query)
		{
			//Este valor es para recuperar el id insertado en las tablas
			int lastId = -1;
			try
			{
				cmd.CommandText = query;
				await OpenConnection();

				var obj = await cmd.ExecuteScalarAsync();
                if (obj == null || obj == DBNull.Value)
                {
                    obj = "xd";  // Leave it blank if obj is null or DBNull
                }
                value = obj.ToString();
				var idDataBase = await cmd.ExecuteScalarAsync();
				if (idDataBase != null)
				{
					lastId = Convert.ToInt32(idDataBase);
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				await CloseConnection();
			}
			return lastId;
		}

		//Esta funcion regresa un datatable de acuerdo al query
		protected async Task<DataTable> GetTable(string query)
		{
			DataTable result = new DataTable();
			try
			{
				await OpenConnection();
				adapter = new MySqlDataAdapter(query, con);
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
		protected async Task<string> GetUniqueValue(string query, params MySqlParameter[] parameters)
		{
			string value = null;
			cmd.CommandText = query;
			cmd.Parameters.Clear();
			cmd.Parameters.AddRange(parameters);

			try
			{
				if (!await OpenConnection()) return null;

				var obj = await cmd.ExecuteScalarAsync();
				value = obj?.ToString();  // Si obj es null, value se mantiene en null
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error al obtener datos de la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				await CloseConnection();
			}
			return value;
		}
	}
}
