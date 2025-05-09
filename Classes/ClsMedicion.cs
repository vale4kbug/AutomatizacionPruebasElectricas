using MySql.Data.MySqlClient;
using System;
using System.Threading.Tasks;
using System.Data;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsMedicion : ClsConnection
    {
        public async Task<int> InsertarMedicion(string productoID, int estacionID, DateTime fecha, decimal valor, string unidad, string estado)
        {
            string query = "INSERT INTO mediciones (ProductoID, EstacionID, Fecha, Valor, Unidad, Estado) " +
                           "VALUES (@ProductoID, @EstacionID, @Fecha, @Valor, @Unidad, @Estado); " +
                           "SELECT LAST_INSERT_ID();"; // Para obtener el ID del último registro insertado

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
                // Utiliza el método PutInDatabase de la clase base para ejecutar la inserción
                return await PutInDatabase(query, parameters);
            }
            catch (MySqlException ex)
            {
                // Aquí puedes implementar un manejo de errores más robusto,
                // como registrar el error en un archivo de registro.
                Console.WriteLine($"Error al insertar medición en la base de datos: {ex.Message}");
                return -1; // Indica que la inserción falló
            }
        }

        // Método para obtener todos los NoSerie de la tabla 'producto'
        public async Task<DataTable> ObtenerNoSerieProductos()
        {
            string query = "SELECT NoSerie FROM producto";
            return await GetTable(query);
        }
    }
}