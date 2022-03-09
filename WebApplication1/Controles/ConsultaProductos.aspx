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
            DataKeyNames="PK_Producto"
            OnRowCommand="ComandRowProducto" 
            >
            <Columns>
                <asp:TemplateField ControlStyle-CssClass="ms-crm-List-Datacell">
                    <ItemTemplate>
                        <asp:CheckBox 
                            runat="server" 
                            ID="idrdSelecciona" 
                            />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="PK_Producto" HeaderText="No de producto" />
                <asp:BoundField DataField="Producto" HeaderText="Producto" />
                <asp:ButtonField ButtonType="Button"
                    runat="server"
                    HeaderText="Consulta producto"
                    CommandName="ConsultaProducto" 
                    Text="ConsultaProducto" />
            </Columns>
        </asp:GridView>
        <br />

        <asp:Button ID="btnConsultaProducto" runat="server" Text="Actualizar" />

    
        <br />
        <asp:TextBox ID="txtPK_Producto" runat="server" Visible="false"></asp:TextBox>

    
        <br />


        Producto<br />
        <asp:TextBox ID="txtProducto" runat="server" Visible="false" ></asp:TextBox>
        <br />
        <br />
        Descricpción:<br />
        <asp:TextBox ID="txtDescripción" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Disponibilidad<br />
        <asp:TextBox ID="txtDisponibilidad" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Precio<br />
        <asp:TextBox ID="txtPrecio" runat="server" Visible="false"></asp:TextBox>
        <br />
        <br />
        Cantidad<br />
        <asp:TextBox ID="txtCantidad" runat="server" Visible="false"></asp:TextBox>

         <br />

         <asp:Button ID="btnActualizarRegistro" runat="server" Text="Actualizar" OnClick="btnActualizarRegistro_Click"   />
    </form>
</body>
</html>
