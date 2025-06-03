using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        NegocioProvincia negocio = new NegocioProvincia();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                DataTable tablaProvincia = negocio.getTabla();
                ddlProvincia.DataSource = tablaProvincia;
                ddlProvincia.DataTextField = "DescripcionProvincia";
                ddlProvincia.DataValueField = "Id_Provincia";
                ddlProvincia.DataBind();
            }
        }

        protected void LimpiarContenidoForm()
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            ddlProvincia.SelectedIndex = 0;
        }

        protected void MostrarMensajeExito()
        {
            lblMensajeExito.Text = "La sucursal se ha agregado con éxito";
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            // string nombre, string descripcion, int idProvincia, string direccion
            Sucursal sucursal = new Sucursal(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(ddlProvincia.SelectedValue), txtDireccion.Text);

            NegocioSucursales negSucursal = new NegocioSucursales();
            int filasAfectadas = negSucursal.AgregarSucursal(sucursal);

            if (filasAfectadas > 0)
            {
                MostrarMensajeExito();
                LimpiarContenidoForm();
            }
            else
            {
                lblMensajeExito.Text = "La sucursal no se pudo agregar.";
            }
        }
    }
}