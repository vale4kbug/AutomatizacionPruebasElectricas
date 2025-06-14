﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
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
		private readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1); // Add this line


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

		//Metodo para realizar y regresar el resultado de un procedimiento almacenado
		public async Task<DataTable> GetProcedure(string procedure, string NoSerie, DateTime fechaA, DateTime fechaB)
		{
			DataTable result = new DataTable();
			try
			{
				await OpenConnection();

				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.AddWithValue("NoSerieProducto", NoSerie);
				cmd.Parameters.AddWithValue("fechaA", fechaA);
				cmd.Parameters.AddWithValue("fechaB", fechaB);
				cmd.CommandText = procedure;

				adapter = new MySqlDataAdapter(cmd);

				await adapter.FillAsync(result);

				cmd.CommandType = CommandType.Text;
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				await CloseConnection();
			}

			return result;
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

		//Esta funcion es para ejecutar querys que no regresan nada directamente, por ejemplo Inserts, Deletes, Updates
		//y opcionalmente puede regresar el ID del último registro insertado
		protected async Task<int> PutInDatabase(string query, params MySqlParameter[] parameters)
		{
			if (con == null || cmd == null)
			{
				MessageBox.Show("Database connection is not properly initialized", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return -1;
			}

			int lastId = -1;
			await _semaphore.WaitAsync(); // Acquire the semaphore

			try
			{
				cmd.CommandText = query;
				cmd.Parameters.Clear();
				cmd.Parameters.AddRange(parameters);

				await OpenConnection();
				var result = await cmd.ExecuteScalarAsync();

				if (result != null && result != DBNull.Value)
				{
					lastId = Convert.ToInt32(result);
				}
				else if (query.ToLower().Contains("insert"))
				{
					cmd.CommandText = "SELECT LAST_INSERT_ID();";
					var idResult = await cmd.ExecuteScalarAsync();
					if (idResult != null && idResult != DBNull.Value)
					{
						lastId = Convert.ToInt32(idResult);
					}
				}
			}
			catch (MySqlException ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				await CloseConnection();
				_semaphore.Release(); // Release the semaphore
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
			await _semaphore.WaitAsync(); // Acquire the semaphore

			try
			{
				if (!await OpenConnection()) return null;

				cmd.CommandText = query;
				cmd.Parameters.Clear();
				cmd.Parameters.AddRange(parameters);

				var obj = await cmd.ExecuteScalarAsync();
				value = obj?.ToString();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Error al obtener datos de la base de datos.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				await CloseConnection();
				_semaphore.Release(); // Release the semaphore
			}
			return value;
		}
	}
}