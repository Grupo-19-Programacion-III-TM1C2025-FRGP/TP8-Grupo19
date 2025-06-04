<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EliminarSucursal.aspx.cs" Inherits="Vistas.EliminarSucursal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
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
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Eliminar Sucursal"></asp:Label>
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="Label2" runat="server" Text="Ingresar ID Sucursal"></asp:Label>
            <asp:TextBox ID="txtEliminar" runat="server" Height="18px" style="margin-left: 28px" Width="185px"></asp:TextBox>
            <asp:RegularExpressionValidator ID="revEliminar" runat="server" ControlToValidate="txtEliminar" ErrorMessage="Solo se permiten numeros." ValidationExpression="^[0-9,$]*$"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="rfvEliminar" runat="server" ControlToValidate="txtEliminar" ErrorMessage="El campo se encuentra vacio."></asp:RequiredFieldValidator>
            <asp:Button ID="Button1" runat="server" style="margin-left: 15px" Text="Eliminar" />
        </p>
    </form>
</body>
</html>
