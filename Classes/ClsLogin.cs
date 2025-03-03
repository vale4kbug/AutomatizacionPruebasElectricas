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

		//Metodo para verificar el login
		//Regresa un true si el usuario es correcto, y regresa falso si no coincide el usuario y la contraseña
		public async Task<bool> Log(string username, string password)
		{
			string hola = await GetUniqueValue($"select idusuario from usuarios where username='{username}' and contraseña='{password}'");

			if (hola != null)
			{
				idUsuario = hola;
				return true;
			}
			return false;
		}


		//Con este metodo se obtiene el nombre del usuario logeado
		public async Task<string> GetUserFullName()
		{
			string nombre = await GetUniqueValue($"select concat(nombre, ' ', apellido) from usuarios where idusuario={idUsuario}");
			return nombre;
		}
	}
}
