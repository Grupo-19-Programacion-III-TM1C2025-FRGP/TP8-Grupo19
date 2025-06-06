﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using Entidades;

namespace Datos
{
    public class DaoProvincia
    {
        Conexion _conexion = new Conexion();
        public DaoProvincia() { }

        public Provincia getProvincia(Provincia pro)
        {
            DataTable tabla = _conexion.TraerTabla("Select * from Provincia where Id_Provincia=" + pro.getIdProvincia(), "Provincia");
            pro.setIdProvincia(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            pro.setDescripcionProvincia(tabla.Rows[0][1].ToString());

            return pro;
        }
        public DataTable getTablaProvincia()
        {
            DataTable tabla = _conexion.TraerTabla("Select Id_Provincia, DescripcionProvincia from Provincia", "Provincia");
            return tabla;
        }
    }
}
