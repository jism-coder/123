<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ventas.aspx.cs" Inherits="WebApplication1.Modelos.Ventas1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 859px;
            height: 79px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Se esta creando una  venta</h1>
            <table class="auto-style1">
                <tr>
                    <td>Producto:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtproducto" runat="server"></asp:TextBox>
                    </td>
                    <td>Usuario:</td>
                    <td>
                        <asp:TextBox ID="txtusuario" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Total:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txttotal" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">Cantidad:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Fecha:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtfecha" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">Forma de Pago:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtfp" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="btnenviar" runat="server" Text="Enviar" OnClick="btnenviar_Click" />
        <asp:TextBox ID="txtenviar" runat="server" Height="174px" Width="309px"></asp:TextBox>
    </form>
</body>
</html>
