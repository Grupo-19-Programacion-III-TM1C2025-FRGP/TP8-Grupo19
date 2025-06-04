using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{   
    public class Sucursal
    {
        //ID_SUCURSAL, NOMBRE, DESCRIPCIÓN, PROVINCIA, y DIRECCIÓN
        private int IdSucursal;
        private string NombreSucursal;
        private string DescripcionSucursal;
        private int IdProvincia;
        //private string DescProvincia;
        private string DireccionSucursal;
        public Sucursal() { }
        public Sucursal(string nombre, string descripcion, int idProvincia, string direccion)
        {
            NombreSucursal = nombre;
            DescripcionSucursal = descripcion;
            IdProvincia = idProvincia;
            DireccionSucursal = direccion;
        }
        public int getIdSucursal()
        {
            return IdSucursal;
        }
        public void setIdSucursal(int idSucursal)
        {
            IdSucursal = idSucursal;
        }
        public String getNombreSucursal()
        {
            return NombreSucursal;
        }
        public void setNombreSucursal(String nombreSucursal)
        {
            NombreSucursal = nombreSucursal;
        }
        public string getDescripcionSucursal()
        {
            return DescripcionSucursal;
        }
        public void setDescripcionSucursal (string descripcionSucursal)
        {
            DescripcionSucursal = descripcionSucursal;
        }
        public int getIdProvincia()
        {
            return IdProvincia;
        }
        public void setIdProvincia(int idProvincia)
        {
            IdProvincia = idProvincia;
        }
        public string getDireccionSucursal()
        {
            return DireccionSucursal;
        }
        public void setDireccionSucursal(string direccionSucursal)
        {
            DireccionSucursal = direccionSucursal;
        }
    }
}
