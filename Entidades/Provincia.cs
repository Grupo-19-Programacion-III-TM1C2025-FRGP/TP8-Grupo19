using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        public int _idProvincia;
        public string _descripcionProvincia;

        // GETTERS
        public int getIdProvincia()
        {
            return _idProvincia;
        }
        public string getDescripcion()
        {
            return _descripcionProvincia;
        }

        // SETTERS
        public void setIdProvincia(int id)
        {
            _idProvincia = id;
        }
        public void setDescripcionProvincia(string descripcion)
        {
            _descripcionProvincia = descripcion;
        }

    }
}
