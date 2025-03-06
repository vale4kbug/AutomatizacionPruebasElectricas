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

		public async Task<DataTable> GetUsers(string filtro)
		{
			DataTable usuarios = await GetTable($"select idUsuario as ID, nombre as Nombre, apellido as Apellido, username as Usuario from usuarios " +
				$"where nombre like '%{filtro}%' or apellido='%{filtro}%' or username='%{filtro}%' or IDUsuario like '%{filtro}%'");
			return usuarios;
		}

		public async Task GetUser(string id)
		{
			DataTable datosUsuario = await GetTable("select Nombre, Apellido, FechaContratacion, FotoRuta, Username, Contraseña " +
				$"from usuarios where IDUsuario = {id}");

			sendDatos(datosUsuario);
		}

		//Metodo para insertar un usuario
		public async Task<int> PutUser(string nombre, string apellido, DateTime fechaContratacion, string fotoRuta, string username, string password)
		{
			return await PutInDatabase("insert into usuarios (nombre, apellido, FechaContratacion, FotoRuta, username, contraseña) " +
				$"values ('{nombre}', '{apellido}', '{fechaContratacion:yyyy-MM-dd HH:mm:ss}', '{fotoRuta}', '{username}', '{password}');" +
				$"SELECT LAST_INSERT_ID();");
		}

		//Metodo para actualizar un usuario, sobrecarga al metodo anterior
		public async Task PutUser(string id, string nombre, string apellido, DateTime fechaContratacion, string fotoRuta, string username, string password)
		{
			await PutInDatabase($"UPDATE usuarios SET nombre='{nombre}', apellido='{apellido}', FechaContratacion='{fechaContratacion:yyyy-MM-dd HH:mm:ss}'," +
				$"FotoRuta='{fotoRuta}', username='{username}', Contraseña='{password}' where IDUsuario='{id}'");
		}

		//Metodo para eliminar un usuario
		public async Task<int> DeleteUser(string id)
		{
			return await PutInDatabase($"delete from usuarios where IDUsuario='{id}'");
		}
	}
}
