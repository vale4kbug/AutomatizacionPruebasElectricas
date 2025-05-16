using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatizacionPruebasElectricas.Classes
{
	public class ClsLogin : ClsConnection
	{
		string idUsuario;

		public string UsuarioId { get { return idUsuario; } }

		//Metodo para verificar el login
		//Regresa un true si el usuario es correcto, y regresa falso si no coincide el usuario y la contraseña
		public async Task<bool> Log(string username, string password)
		{
			string query = "SELECT idusuario FROM usuarios WHERE username = @username AND contraseña = @password";
			var parameters = new MySqlParameter[]
			{
				new MySqlParameter("@username", username),
				new MySqlParameter("@password", password)  // Si la contraseña está encriptada, usa SHA2(password, 256) en MySQL
            };

			string resultado = await GetUniqueValue(query, parameters);
			if (resultado != null)
			{
				idUsuario = resultado;
				return true;
			}
			return false;
		}


		//Con este metodo se obtiene el nombre del usuario logeado
		public async Task<string> GetUserFullName()
		{
			string query = "SELECT CONCAT(nombre, ' ', apellido) FROM usuarios WHERE idusuario = @idUsuario";
			var parameters = new MySqlParameter[]
			{
				new MySqlParameter("@idUsuario", idUsuario)
			};

			return await GetUniqueValue(query, parameters);
		}
	}
}
