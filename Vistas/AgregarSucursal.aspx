<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="Vistas.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 129px;
        }
        .auto-style3 {
            width: 216px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 160px">
            <asp:HyperLink ID="HyperLinkAgregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLinkListado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLinkEliminar" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar sucursal</asp:HyperLink>
        </div>
        <p style="margin-left: 160px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="GRUPO N 19"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 160px">
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Agregar Sucursal"></asp:Label>
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Nombre Sucursal:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtNombre" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Descripcion:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDescripcion" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Dirección:"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtDireccion" runat="server" Width="197px"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
