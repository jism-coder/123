<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaVentas.aspx.cs" Inherits="WebApplication1.Controles.ConsultaVentas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Consultas ventas</h1>
            <asp:GridView 
                ID="idGvVentas"
                runat="server"
                AutoGenerateColumns="false"
                >
                <Columns>
                    <asp:BoundField DataField="PK_Ventas" HeaderText="No de ventas" />
                    <asp:BoundField DataField="Producto" HeaderText="Producto" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
