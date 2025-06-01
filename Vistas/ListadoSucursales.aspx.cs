using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using System.Data;
using Negocio;
using System.Data.SqlClient;


namespace Vistas
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        NegocioSucursales negocio = new NegocioSucursales();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                DataTable tablaSucursales = negocio.getTabla();
                grvSucursales.DataSource = tablaSucursales;
                grvSucursales.DataBind();
                
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            grvSucursales.DataSource = negocio.FiltrarSucursal(txtFiltrar.Text); ;
            grvSucursales.DataBind();
            txtFiltrar.Text = "";
        }
    }
}