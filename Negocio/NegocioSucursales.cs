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
    

       public DataTable FiltrarSucursal(string IdSucursal)
        {
            Conexion conexion = new Conexion();
            string consultaSQL = $"SELECT\r\nId_Sucursal ,\r\nNombreSucursal ,\r\nDescripcionSucursal, \r\nId_ProvinciaSucursal ,\r\nDireccionSucursal\r\nFROM Sucursal INNER JOIN Provincia\r\nON Id_Provincia=Id_ProvinciaSucursal \r\nWHERE Id_Sucursal = {IdSucursal} ";
            string nombreTabla = "Sucursales";
            return conexion.TraerTabla(consultaSQL, nombreTabla);
        }
    }
}

