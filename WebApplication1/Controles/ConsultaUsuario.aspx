<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaUsuario.aspx.cs" Inherits="WebApplication1.Controles.ConsultaUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consultas usuarios</h1>
            <asp:GridView 
                ID="idGvUsuarios"
                runat="server"
                AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="PK_Usuarios" HeaderText="No de usuario" />
                    <asp:BoundField DataField="Nombre" HeaderText="Usuario" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
