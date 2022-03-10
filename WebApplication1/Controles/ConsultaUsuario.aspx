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
            <h1>Consultas usuarios</h1></div>
            <asp:GridView 
                ID="idGvUsuarios"
                runat="server"
                AutoGenerateColumns="false"
                DataKeyNames="PK_Usuarios"
                OnRowCommand="ComandRowUsuario" 
                >
                <Columns>
                    <asp:TemplateField ControlStyle-CssClass="ms-crm-List-Datacell">
                        <ItemTemplate>
                            <asp:CheckBox 
                                ID="idrSelecciona"
                                runat="server" 
                                />
                        </ItemTemplate>
                    </asp:TemplateField>                 
                    <asp:BoundField DataField="PK_Usuarios" HeaderText="No de usuario" />
                    <asp:BoundField DataField="Nombre" HeaderText="Usuario" />
                    <asp:ButtonField ButtonType="Button"
                       runat="server" 
                       HeaderText="Consulta usuario"
                       CommandName="Consultausuario"
                       Text="ConsultarUsuario"                                 
                        />                       
               </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="btnConsultaUsuario" runat="server" Text="Limpia consulta"  OnClick="btnConsultaUsuario_Click"/>
            <br />
            <asp:TextBox ID="txtPK_Usuario" runat="server" Visible="false"></asp:TextBox>
            <br />
            Nombre:<br />
            <asp:TextBox ID="txtNombre" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            Apellido paterno:<br />
            <asp:TextBox ID="txtApeterno" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            Apellido materno:<br />
            <asp:TextBox ID="txtAmaterno" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            Direccion:<br />
            <asp:TextBox ID="txtDireccion" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            Telefono:<br />
            <asp:TextBox ID="txtTelefono" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            RFC:<br />
            <asp:TextBox ID="txtRFC" runat="server" Visible="false"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnactualizarUsuario" runat="server" Text="Actualizar" OnClick="btnActualizarRegistroUsuario_Click" /> />
       
    </form>
</body>
</html>
