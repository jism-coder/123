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

        </div>
            <asp:GridView 
                ID="idGvVentas"
                runat="server"
                AutoGenerateColumns="false"
                DataKeyNames="PK_Ventas"
                OnRowCommand="ComandRowVentas" OnSelectedIndexChanged="idGvVentas_SelectedIndexChanged" 
                >
                <Columns>
                    <asp:TemplateField ControlStyle-CssClass="ms-crm-List-Datacell">
                        <ItemTemplate>
                            <asp:CheckBox 
                                ID="idrdSelecciona" 
                                runat="server" 
                                />
                        </ItemTemplate>         
                        </asp:TemplateField>
                            <asp:BoundField DataField="PK_Ventas" HeaderText="No de ventas" />
                            <asp:BoundField DataField="Producto" HeaderText="Venta" />
                            <asp:ButtonField ButtonType="Button"
                                runat="server"
                                 HeaderText="Consulta venta"
                                CommandName="ConsultaVenta"
                                Text="ConsultaVenta"
                                />                    
                </Columns>
            </asp:GridView>
        <br />
        <asp:Button ID="btnConsultaVenta" runat="server" Text="Limpiar consulta" OnClick="btnConsultaVenta_Click"/>
        <br />
        Producto:<br />
        <asp:TextBox ID="txtProducto" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Cantidad:<br />
        <asp:TextBox ID="txtCantidad" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Usuario:<br />
        <asp:TextBox ID="txtUsuario" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Fecha:<br />
        <asp:TextBox ID="txtFecha" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Forma_pago:<br />
        <asp:TextBox ID="txtFormapago" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
    </form>
</body>
</html>
