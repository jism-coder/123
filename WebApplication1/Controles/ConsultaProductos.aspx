<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaProductos.aspx.cs" Inherits="WebApplication1.Controles.ConsultaProductos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Consulta productos</div>
        <asp:GridView 
            ID="idGvProductos"
            runat="server"
            AutoGenerateColumns="false"
            >
            <Columns>


                <asp:BoundField DataField="PK_Producto" HeaderText="No de producto" />
                <asp:BoundField DataField="Producto" HeaderText="Producto" />

            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
