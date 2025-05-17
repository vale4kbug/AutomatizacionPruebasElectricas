using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsEspecificaciones:ClsConnection
    {
        public Action<DataTable> sendDatos;

       
        public async Task<DataTable> GetEspecificaciones(string filtro)
        {
            DataTable especificaciones = await GetTable($"select IdEspecificacion as ID, Descripcion as Nombre from especificaciones " +
                $"where IdEspecificacion like '%{filtro}%' or Descripcion='%{filtro}%'");
            return especificaciones;
        }

        public async Task GetEspecificacion(string id)
        {
            DataTable datosEspecificaciones = await GetTable("select IdEspecificacion, Descripcion " +
                $"from especificaciones where IdEspecificacion = {id}");

            sendDatos(datosEspecificaciones);
        }



        //Metodo para insertar
        public async Task<int> PutEspecificacion(string id,string desc,string back)
        {
            return await PutInDatabase("insert into especificaciones (Descripcion) " +
                $"values ('{desc}');");
        }

        //Metodo para actualizar, sobrecarga al metodo anterior
        public async Task PutEspecificacion(string id, string desc)
        {
            await PutInDatabase($"UPDATE especificaciones SET Descripcion='{desc}' where IdEspecificacion='{id}'");
        }

        //Metodo para eliminar u
        public async Task<int> DeleteEspecificacion(string id)
        {
            return await PutInDatabase($"delete from especificaciones where IdEspecificacion='{id}'");

        }
    }
}
