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
            DataTable dt;

            if(txtFiltrar.Text.Trim() == "")
            {   
                dt = negocio.MostrarTodo(); // Por si no se ingresa nada en el textbox
            } 
            else
            {
                dt = negocio.MostrarSucursalFiltrada(txtFiltrar.Text);
            }
            grvSucursales.DataSource = dt;
            grvSucursales.DataBind();
            txtFiltrar.Text = "";
        }

        protected void btnMostrar_Click(object sender, EventArgs e)
        {
            grvSucursales.DataSource = negocio.MostrarTodo(); 
            grvSucursales.DataBind();
            txtFiltrar.Text = "";
        }
    }
}