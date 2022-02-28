<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="WebApplication1.Controles.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Se esta creando un producto</h1>
            <table style="width:100%;">
                <tr>
                    <td>Producto</td>
                    <td>
                        <asp:TextBox ID="txtproducto" runat="server"></asp:TextBox>
                    </td>
                    <td>Precio</td>
                    <td>
                        <asp:TextBox ID="txtprecio" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Descripcion</td>
                    <td>
                        <asp:TextBox ID="txtdescripcion" runat="server"></asp:TextBox>
                    </td>
                    <td>Cantidad</td>
                    <td>
                        <asp:TextBox ID="txtcantidad" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Disponibilidad</td>
                    <td>
                        <asp:TextBox ID="txtdispo" runat="server"></asp:TextBox>
                    </td>
                    <td>Total</td>
                    <td>
                        <asp:TextBox ID="txtotal" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        <asp:Button ID="btnenviar" runat="server" Text="Enviar" OnClick="btnenviar_Click" />
        <asp:TextBox ID="txtenviar" runat="server" Height="141px" Width="299px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br/>
    <br/>
    <br/>
    &nbsp;<asp:Button ID="bto1Producto" runat="server" Text="Consulta 1 producto" OnClick="bto1Producto_Click" />
        <br />
    &nbsp;<asp:Label ID="CualproductoId" runat="server" Text="Que producto?"></asp:Label>
&nbsp;<asp:TextBox ID="txboxQueProducto" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtResultadoQueProducto" runat="server" Height="58px" Width="248px"></asp:TextBox>
        <br />
        Consultas lista de objetos<br />
        <asp:Button ID="btnList" runat="server" Text="Lista porductos" OnClick="btnList_Click" />
        <br />
        <asp:TextBox ID="txtLits" runat="server" Height="129px" Width="255px"></asp:TextBox>
      </div>
    </form>
</body>
</html>
