using System;
using System.Collections.Generic;
using System.Data;
using Datos;
using Entidades;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    public class NegocioSucursales
    {
        readonly DaoSucursal dao = new DaoSucursal();
        public DataTable getTabla()
        {
            return dao.getTablaSucursales();
        }
        public Sucursal get(int id)
        {
            Sucursal sucursal = new Sucursal();
            sucursal.setIdSucursal(id);
            return dao.getSucursal(sucursal);
        }
        // Acá devuelvo un dataTable pero ¿Sería mejor devolver un solo objeto Sucursal y agregarlo al gvSucursales?
        public DataTable MostrarSucursalFiltrada(string idSucursal)
        {
            return dao.FiltrarSucursal(idSucursal);
        }
        public DataTable MostrarTodo()
        {
            return dao.getTablaSucursales();
        }
        public int AgregarSucursal(Sucursal suc)
        {
            int filasAfectadas = dao.agregarSucursal(suc);
            return filasAfectadas;
        }

        public int EliminarSucursalPorId(string id)
        {
            return dao.EliminarSucursalPorId(id);
        }
    }
}

