using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Datos;

namespace Negocio
{
    public class NegocioProvincia
    {
        public NegocioProvincia() { }

        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincia();
        }
    }
}
