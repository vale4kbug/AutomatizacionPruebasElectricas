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

    }
}
