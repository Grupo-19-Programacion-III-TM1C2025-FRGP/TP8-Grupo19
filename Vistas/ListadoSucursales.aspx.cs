using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Data;
using Negocio; 


namespace Vistas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        NegocioSucursales negocio = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable tablaSucursales = negocio.getTabla();
                grvSucursales.DataSource = tablaSucursales;
                grvSucursales.DataBind();

            }
        }
    }
}