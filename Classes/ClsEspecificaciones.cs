using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsEspecificaciones : ClsConnection
    {
        public Action<DataTable> sendDatos;

        //metodo para agregar
        //modificar
        //eliminar
        //buscar
        public async Task<DataTable> GetEspecificaciones(string filtro)
        {
            DataTable especificaciones = await GetTable($"select IdEspecificacion as ID, Descripcion as Nombre from especificaciones " +
                $"where IdEspecificacion like '%{filtro}%' or Descripcion='%{filtro}%'");
            return especificaciones;
        }

        public async Task GetEspecificacion(string id)
        {
            DataTable datosEspecificaciones = await GetTable("select IdEspecificacion, Descripcion" +
                $"from especificaciones where IdEspecificacion = {id}");

            sendDatos(datosEspecificaciones);
        }
		public async Task<int> DeleteEspecificacion(string id)
		{
			return await PutInDatabase($"delete from especificaciones where IdEspecificacion='{id}'");
		}
		//Metodo para insertar
		public async Task<int> PutEspecificacion(string desc)
        {
            return await PutInDatabase("insert into especificaciones (descripcion) " +
                $"values ('{desc}');" +
                $"SELECT LAST_INSERT_ID();");
        }  //Metodo para insertar
        public async Task<int> PutEspecificacion(string id,string desc,string back)
        {
            return await PutInDatabase("insert into especificaciones (Descripcion) " +
                $"values ('{desc}');");
        }


        //Metodo para actualizar, sobrecarga al metodo anterior
        public async Task PutEspecificacion(string id, string desc)
        {
            await PutInDatabase($"UPDATE especificaciones SET descripcion='{desc}' where IdEspecificacion='{id}'");
        }


		public async Task<int> DeleteEspecificacionenOtros(string id)
		{
			return await PutInDatabase($"delete from especificacionesproducto where IDEspecificacion='{id}'");

		}

	}
}
