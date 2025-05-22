using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionPruebasElectricas.Classes
{
    public class ClsProductos : ClsConnection
    {
        int hola;
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
        public async Task<int> DeleteEspecificacionProducto(string idproducto, string idespecificacion)
        {
            return await PutInDatabase($"delete from especificacionesproductos where IDProducto='{idproducto}' and IDEspecificacion='{idespecificacion}'");
        }
        public async Task<int> DeleteProcedimientoProducto(string idprocedimientoproducto)
        {
            return await PutInDatabase($"delete from procedimientosproducto where idprocedimientosproductos='{idprocedimientoproducto}'");
        }

        
        public async Task<int> PutProducto(string Modelo, string descripcion)
        {
            return await PutInDatabase("insert into producto (Modelo,Descripcion) " +
                $"values ('{Modelo}', '{descripcion}' );" +
                $"SELECT LAST_INSERT_ID();");
        }

        public async Task PutProducto(string NoSerie, string Model, string descripcion)
        {
            await PutInDatabase($"UPDATE producto SET Modelo='{Model}', Descripcion='{descripcion}'" +
                $"where NoSerie='{NoSerie}'");
        }

        public async Task<int> EspecificacionesPutProducto(string IDProducto, string IDEspecificacion, string Valor)
        {
            return await PutInDatabase("insert into especificacionesproducto (IDProducto,IDEspecificacion,Valor) " +
                $"values ('{IDProducto}', '{IDEspecificacion}','{Valor}' );");
        }
        public async Task <int>EspecificacionesActualizarProducto(string IDProducto, string IDEspecificacion, string Valor)
        {
            return await PutInDatabase($"UPDATE especificacionesproducto SET Valor = '{Valor}' WHERE IDProducto = '{IDProducto}' AND IDEspecificacion = '{IDEspecificacion}';");
        }

        public async Task<int> ProcedimientosPutProducto(string IDProducto, string IDProcedimiento)
        {
            {
                return await PutInDatabase("insert into procedimientosproducto (idproducto,idprocedimiento) " +
                    $"values ('{IDProducto}', '{IDProcedimiento}' );" +
                    $"SELECT LAST_INSERT_ID();");
            }
        }
    


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

        public async Task<DataTable> GetEspecificacion(string idProcedimiento)
        {
            return await GetTable($"SELECT e.IdEspecificacion, e.Descripcion, ep.Valor FROM especificaciones e left join especificacionesproducto ep ON e.IdEspecificacion = ep.IDEspecificacion where e.IdEspecificacion={idProcedimiento}");
        }

        public async Task<DataTable> GetProcedimiento(string idProcedimiento)
        {
            return await GetTable($"SELECT e.IdProcedimiento, e.Descripcion FROM procedimientos e where e.IdProcedimiento={idProcedimiento}");
        }

    }
}