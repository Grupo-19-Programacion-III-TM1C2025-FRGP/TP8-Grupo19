<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListadoSucursales.aspx.cs" Inherits="Vistas.WebForm2" %>

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
            width: 244px;
        }
        .auto-style3 {
            width: 296px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p style="margin-left: 160px">
            <asp:HyperLink ID="HyperLinkAgregar" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar Sucursal</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLinkListado" runat="server" NavigateUrl="~/ListadoSucursales.aspx">Listado de Sucursales</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLinkEliminar" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar sucursal</asp:HyperLink>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p style="margin-left: 160px">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Listado de Sucursales"></asp:Label>
        </p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Búsqueda ingrese Id sucursal:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtFiltrar" runat="server" Width="240px"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtFiltrar" ValidationExpression="^[0-9,$]*$">Solo ingrese valores numericos</asp:RegularExpressionValidator>
                    <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" style="margin-left: 190px" Text="Filtrar" />
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
        </table>
        <asp:GridView ID="grvSucursales" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
