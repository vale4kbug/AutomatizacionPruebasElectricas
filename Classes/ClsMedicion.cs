using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Data;
using Google.Protobuf.WellKnownTypes;
using System.Collections.Generic;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsMedicion : ClsConnection
    {
        public async Task<int> InsertarMedicion(string productoID, int estacionID, DateTime fecha, decimal valor, string unidad, string estado)
        {
            string query = "INSERT INTO mediciones (ProductoID, EstacionID, Fecha, Valor, Unidad, Estado) " +
                           "VALUES (@ProductoID, @EstacionID, @Fecha, @Valor, @Unidad, @Estado); " +
                           "SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@ProductoID", productoID),
                new MySqlParameter("@EstacionID", estacionID),
                new MySqlParameter("@Fecha", fecha),
                new MySqlParameter("@Valor", valor),
                new MySqlParameter("@Unidad", unidad),
                new MySqlParameter("@Estado", estado)
            };

            try
            {
                return await PutInDatabase(query, parameters);
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Error al insertar medición: {ex.Message}");
                return -1;
            }
        }

        public async Task<DataTable> ObtenerNoSerieProductos()
        {
            string query = "SELECT NoSerie, Descripcion FROM producto";
            return await GetTable(query);
        }

        public async Task<DataTable> GetLineasProduccion()
        {
            string query = "SELECT LineaID, Nombre, Descripcion FROM lineasproduccion";
            return await GetTable(query);
        }
        public async Task<(string Descripcion, int Valor)> GetValorDePrueba(int productoID)
        {
            string query = $"SELECT e.Descripcion, ep.Valor " +
                           $"FROM especificacionesproducto ep " +
                           $"INNER JOIN especificaciones e ON e.IdEspecificacion = ep.IDEspecificacion " +
                           $"WHERE ep.IDProducto = {productoID}";

            DataTable result = await GetTable(query);

            if (result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                return (row["Descripcion"].ToString(), Convert.ToInt32(row["Valor"]));
            }

            return (null, 0); // Return default values if no data found
        }
        public async Task<DataTable> GetEstacionesPrueba(int lineaID)
        {
            string query = $"SELECT EstacionID, LineaID, Nombre, Descripcion FROM estacionesprueba WHERE LineaID = {lineaID}";
            return await GetTable(query);
        }

        public async Task<Dictionary<string, double>> GetEspecificacionesProducto(int productoID)
        {
            var especificaciones = new Dictionary<string, double>();

            string query = $"SELECT e.Descripcion, ep.Valor " +
                           $"FROM especificacionesproducto ep " +
                           $"INNER JOIN especificaciones e ON e.IdEspecificacion = ep.IDEspecificacion " +
                           $"WHERE ep.IDProducto = {productoID}";

            DataTable result = await GetTable(query);

            foreach (DataRow row in result.Rows)
            {
                string descripcion = row["Descripcion"].ToString();
                double valor = Convert.ToDouble(row["Valor"]);
                especificaciones[descripcion] = valor;
            }

            return especificaciones;
        }

        internal async Task InsertarMedicion(string v1, int v2, DateTime now, double v3, string unidad, string estado)
        {
            throw new NotImplementedException();
        }
    }
}