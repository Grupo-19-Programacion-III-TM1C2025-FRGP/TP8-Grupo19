using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminarSucursal(object sender, EventArgs e)
        {
            NegocioSucursales negocio = new NegocioSucursales();
            int result = negocio.EliminarSucursalPorId(txtEliminar.Text);

            if (result > 0)
            {
               
                MostrarMensajeEliminado();
            }
            else
            {
                MostrarMensajeError();
            }

            txtEliminar.Text = "";
        }

        protected void MostrarMensajeEliminado()
        {
            lblMensaje.Text = "La sucursal se ha eliminado con éxito.";
        }
        protected void MostrarMensajeError()
        {
            lblMensaje.Text = "No se encotró una sucursal con el ID ingresado.";
        }

    }
}