using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getUsuario();
        }
        protected void getUsuario()
        {
            List<ModeloUsuario> query = new List<ModeloUsuario>();
            Consultas.Consultas c = new Consultas.Consultas();
            query = c.getUsuario();

            if (query.Count > 0)
            {
                idGvUsuarios.AllowPaging = true;

                idGvUsuarios.DataSource = query;

                idGvUsuarios.DataBind();

            }
        }
        protected void ComandRowUsuario(object sender,GridViewCommandEventArgs e)
        {
            int nRowIndex = Int32.Parse(e.CommandArgument.ToString());
            string pk = idGvUsuarios.DataKeys[nRowIndex].Value.ToString();
            int valor = int.Parse(pk);
            
            Consultas.Consultas c = new Consultas.Consultas();
            ModeloUsuario obj = new ModeloUsuario();
            obj = c.get1Usuario(valor);

            txtPK_Usuario.Text = obj.PK_Usuarios.ToString();
            txtNombre.Text = obj.Nombre;
            txtNombre.Visible = true;

            txtApeterno.Text = obj.Apellido_Paterno;
            txtApeterno.Visible = true;

            txtAmaterno.Text = obj.Apellido_Materno;
            txtAmaterno.Visible = true;

            txtDireccion.Text = obj.Direccion;
            txtDireccion.Visible = true;

            txtTelefono.Text = obj.Telefono.ToString();
            txtTelefono.Visible = true;

            txtRFC.Text = obj.RFC;
            txtRFC.Visible = true;
        }

        protected void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.Visible = false;

            txtApeterno.Text = "";
            txtApeterno.Visible = false;

            txtAmaterno.Text = "";
            txtAmaterno.Visible = false;

            txtDireccion.Text = "";
            txtDireccion.Visible = false;

            txtTelefono.Text = "";
            txtTelefono.Visible = false;

            txtRFC.Text = "";
            txtRFC.Visible = false;

        }

        protected void btnActualizarRegistroUsuario_Click(object sender, EventArgs e)
        {
            int pk = Int32.Parse(txtPK_Usuario.Text);
            int Telefono = Int32.Parse(txtTelefono.Text);

            ModeloUsuario obj = new ModeloUsuario();
            Consultas.Consultas c = new Consultas.Consultas();

            obj.PK_Usuarios = pk;
            obj.Nombre = txtNombre.Text;
            obj.Apellido_Paterno = txtApeterno.Text;
            obj.Apellido_Materno = txtAmaterno.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Telefono = Telefono;
            obj.RFC = txtRFC.Text;

            c.actualizaRegistroUsuario(obj);


        }
    }
}