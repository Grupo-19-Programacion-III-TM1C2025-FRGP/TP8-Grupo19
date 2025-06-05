using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class DaoSucursal
    {
        Conexion conexion = new Conexion();
        public Sucursal getSucursal(Sucursal suc)
        {
            DataTable tabla = conexion.TraerTabla("Select * from Sucursal where Id_Sucursal=" + suc.getIdSucursal(), "Sucursal");
            suc.setIdSucursal(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            suc.setNombreSucursal(tabla.Rows[0][1].ToString());
            suc.setDescripcionSucursal(tabla.Rows[0][2].ToString());
            suc.setIdProvincia(Convert.ToInt32(tabla.Rows[0][3].ToString()));
            suc.setDireccionSucursal(tabla.Rows[0][4].ToString());
            return suc;
        }
        public DataTable getTablaSucursales()
        {
            DataTable tabla = conexion.TraerTabla("Select Id_Sucursal, NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal from Sucursal", "Sucursal");
            return tabla;
        }
        public int agregarSucursal(Sucursal suc)
        {
            string consultaSQL = $"INSERT INTO Sucursal (NombreSucursal, DireccionSucursal, DescripcionSucursal, Id_ProvinciaSucursal) SELECT '{suc.getNombreSucursal()}', '{suc.getDireccionSucursal()}', '{suc.getDescripcionSucursal()}', '{suc.getIdProvincia()}'";
            Conexion cn = new Conexion();

            int filasAfectadas = cn.ejecutarConsulta(consultaSQL);
            return filasAfectadas;
        }
        public DataTable FiltrarSucursal(string IdSucursal)
        {
            Conexion conexion = new Conexion();
            string consultaSQL = $"SELECT\r\nId_Sucursal ,\r\nNombreSucursal ,\r\nDescripcionSucursal, \r\nId_ProvinciaSucursal ,\r\nDireccionSucursal\r\nFROM Sucursal INNER JOIN Provincia\r\nON Id_Provincia=Id_ProvinciaSucursal \r\nWHERE Id_Sucursal = {IdSucursal} ";
            string nombreTabla = "Sucursales";
            return conexion.TraerTabla(consultaSQL, nombreTabla);
        }

        public int EliminarSucursalPorId(string id)
        {
            string consultaSQL = $"DELETE FROM Sucursal WHERE Id_Sucursal = {id}";
            return conexion.ejecutarConsulta(consultaSQL);
        }
    }
}
