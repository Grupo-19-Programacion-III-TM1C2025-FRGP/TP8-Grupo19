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
        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursales();
        }

        public Sucursal get(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucursal = new Sucursal();
            sucursal.setIdSucursal(id);
            return dao.getSucursal(sucursal);
        }
    }
}
