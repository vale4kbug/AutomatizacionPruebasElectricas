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
                            $"from productos " +
                            $"where NoSerie like '%{filtro}%' or Modelo like '%{filtro}%' or Descripcion like '%{filtro}%'");

            return productos;
        }

        public async Task GetProducto(string id)
        {
            DataTable datosProductos = await GetTable($"select NoSerie as ID, Modelo, Descripcion " +
                            $"from productos " +
                            $"where NoSerie = {id}");

            sendDatos(datosProductos);
        }

       public async Task <DataTable> GetEspecificacion(string filtro) //Forma BuscarEspecificaciones
       {
            DataTable datosEspecificaciones = await GetTable($"select IdEspecificacion as ID, Descripcion " +
                        $"from especificaciones " +
                            $"where IdEspecificacion like '%{filtro}%' or Descripcion like '%{filtro}%'");
            return datosEspecificaciones;
       }


    }
}
