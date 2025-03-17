using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsProductos :ClsConnection
    {
        public Action<DataTable> sendDatos;
        public async Task<DataTable> GetProductos(string filtro)
        {
            DataTable productos = await GetTable($"select NoSerie as ID, Modelo, Descripcion " +
                            $"from producto " +
                            $"where NoSerie like '%{filtro}%' or Modelo like '%{filtro}%' or Descripcion like '%{filtro}%'");
            return productos;
        }
        public async Task GetProducto(string id)
        {
            DataTable datosProductos = await GetTable($"select NoSerie as ID, Modelo, Descripcion " +
                            $"from producto " +
                            $"where NoSerie = {id}");

            sendDatos(datosProductos);
        }



        public async Task<int> DeleteProductoDomino(string id)
        {
            await PutInDatabase($"delete from especificacionesproductos where IdProducto='{id}'");
            await PutInDatabase($"delete from procedimientosproductos where IdProducto='{id}'");
            return await PutInDatabase($"delete from producto where NoSerie='{id}'");
        }

        public async Task<int> PutProducto(string Modelo, string descripcion)
        {
            return await PutInDatabase("insert into producto (Modelo,Descripcion) " +
                $"values ('{Modelo}', '{descripcion}' );" +
                $"SELECT LAST_INSERT_ID();");
        }

        //Metodo para actualizar un usuario, sobrecarga al metodo anterior
        public async Task PutProducto(string NoSerie, string Model,string descripcion)
        {
            await PutInDatabase($"UPDATE producto SET Modelo='{Model}', Descripcion='{descripcion}'" +
                $"where NoSerie='{NoSerie}'");
        }

        public async Task<int> EspecificacionesPutProducto(string IDProducto, string IDEspecificacion,string Valor)
        {
            return await PutInDatabase("insert into especificacionesproducto (IDProducto,IDEspecificacion,Valor) " +
                $"values ('{IDProducto}', '{IDEspecificacion}','{Valor}' );");
        }

        public async Task<int> ProcedimientosPutProducto(string IDProducto, string IDProcedimiento, string Desc)
        {
            return await PutInDatabase("insert into procedimientosproductos (IDProducto, IDProcedimiento, Desc) " +
                $"values ('{IDProducto}', '{IDProcedimiento}', '{Desc}');");
        }



        //Metodo para eliminar un usuario
        public async Task<DataTable> GetEspecificacionesProducto(string idProducto)
        {
            return await GetTable($"SELECT e.IdEspecificacion, e.Descripcion, ep.Valor FROM especificaciones e " +
                                 $"JOIN especificacionesproducto ep ON e.IdEspecificacion = ep.IDEspecificacion " +
                                 $"WHERE ep.IDProducto = '{idProducto}'");
        }

        public async Task<DataTable> GetProcedimientosProducto(string idProducto)
        {
            return await GetTable($"SELECT p.IdProcedimiento, p.Descripcion FROM procedimientos p " +
                                 $"JOIN procedimientosproductos pp ON p.IdProcedimiento = pp.IDProcedimiento " +
                                 $"WHERE pp.IDProducto = '{idProducto}'");
        }

    }
}