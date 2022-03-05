<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="WebApplication1.Controles.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 86px;
            margin-bottom: 0px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            width: 229px;
        }
        .auto-style4 {
            height: 25px;
            width: 229px;
        }
        .auto-style5 {
            height: 22px;
        }
        .auto-style6 {
            width: 229px;
            height: 22px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Se esta creando un usuario</h1>
            <table class="auto-style1">
                <tr>
                    <td>Nombre:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtnombre" runat="server"></asp:TextBox>
                    </td>
                    <td>Direccion:</td>
                    <td>
                        <asp:TextBox ID="txtdireccion" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">Apellido Paterno:</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtpaterno" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style5">Telefono:</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="txtel" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellido Materno:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtmaterno" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">RFC:</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtrfc" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
       
            <asp:Button ID="btnenviar" runat="server" Text="Enviar" OnClick="btnenviar_Click" />
            <asp:TextBox ID="txtenviar" runat="server" Height="174px" Width="309px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br/>
        <br/>
        <br/>
            &nbsp;<asp:Button ID="bto1Usuario" runat="server" Text="Consulta 1 usuario" OnClick="bto1Usuario_Click" />
            <br />
         &nbsp;<asp:Label ID="CualusuarioId" runat="server" Text="Que usuario?"></asp:Label>
            &nbsp;<asp:TextBox ID="txboxQueUsuario" runat="server"></asp:TextBox>
            <br />
            <asp:TextBox ID="txtResultadoQueUsuario" runat="server" Height="217px" Width="370px"></asp:TextBox> <br />
            Consultas lista de usuario<br />
            <asp:Button ID="btnList" runat="server" Text="Lista usuario" OnClick="btnList_Click" />
            <br />
            <asp:TextBox ID="txtLits" runat="server" Height="129px" Width="255px"></asp:TextBox>

        </div>
    </form>
</body>
</html>
