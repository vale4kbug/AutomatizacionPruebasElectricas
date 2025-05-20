using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsProcedimientos:ClsConnection
    {
        public Action<DataTable> sendDatos;


        public async Task<DataTable> GetProcedimientos(string filtro)
        {
            DataTable procedimientos = await GetTable($"select IdProcedimiento as ID, Descripcion as Nombre from procedimientos " +
                $"where IdProcedimiento like '%{filtro}%' or Descripcion='%{filtro}%'");
            return procedimientos;
        }

        public async Task GetProcedimiento(string id)
        {
            DataTable datosProcedimiento = await GetTable("select IdProcedimiento, Descripcion " +
                $"from procedimientos where IdProcedimiento = {id}");

            sendDatos(datosProcedimiento);
        }

        //Metodo para insertar
        public async Task<int> PutProcedimiento( string id,string desc,string idapoyo)
        {
            return await PutInDatabase("insert into procedimientos (IdProcedimiento,descripcion) " +
                $"values ('{id}','{desc}');" );
        }

        //Metodo para actualizar, sobrecarga al metodo anterior
        public async Task PutProcedimiento(string id, string desc)
        {
            await PutInDatabase($"UPDATE procedimientos SET descripcion='{desc}' where IdProcedimiento='{id}'");
        }

        //Metodo para eliminar u
        public async Task<int> DeleteProcedimiento(string id)
        {
            return await PutInDatabase($"delete from procedimientos where IdProcedimiento='{id}'");
        }
        public async Task<int> DeleteProcedimientoenOtros(string id)
        {
            return await PutInDatabase($"delete from procedimientosproductos where idprocedimiento='{id}'");
        }

    }
}
