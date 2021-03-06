using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Funciones;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class Usuario : System.Web.UI.Page
    {
        Consultas.Consultas c = new Consultas.Consultas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //un solo producto
        protected void btnenviar_Click(object sender, EventArgs e)
        {

            
            bool crear = false;
            ////  referencia a this 
            ///La palabras "this" funciona para hacer referencia al campo del control web y se suma con el nombre del campo ejemplo:
            /// sintaxis =   "this.nombrecampo"
            /// esto se puede sumar con la propiedad del texto que se agregó al campo ejemplo:
            /// this.campo.Text;
            txtenviar.Text = this.txtnombre.Text;
            ModeloUsuario obj = new ModeloUsuario();
            obj.Nombre = this.txtnombre.Text;
            obj.Apellido_Paterno = this.txtpaterno.Text;
            obj.Apellido_Materno = this.txtmaterno.Text;
            obj.Direccion = this.txtdireccion.Text;
            #region valida telefono en try
            try
            {
                obj.Telefono = Int32.Parse(this.txtel.Text);

            }
            catch (Exception ex)
            {

                txtenviar.Text = ex.Message;
            }
            finally
            {

            }
            #endregion
            obj.RFC = this.txtrfc.Text;
            crear = Funciones.Funciones.Usuario(obj);
            if (crear == false)
            {
                txtenviar.Text = "El usuario no se creo correctamente";
            }
            else
            {
                txtenviar.Text = "El usuario se creo correctamente";

            }
        }
           
        protected void bto1Usuario_Click(object sender, EventArgs e)
        {
            int usuario = int.MaxValue;
            try
            {
                
                usuario = int.Parse(this.txboxQueUsuario.Text);
                ModeloUsuario objUsuario = new ModeloUsuario();
                objUsuario = c.get1Usuario(usuario);
                txtResultadoQueUsuario.Text = objUsuario.PK_Usuarios + "|" + objUsuario.Nombre +"|" + objUsuario.Apellido_Paterno; 

            }
            catch (Exception exbto1Usuario_Click)

            {
                this.txtenviar.Text = exbto1Usuario_Click.Message;
                throw;
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtLits.Text = "procesando...";
                List<ModeloUsuario> objList = new List<ModeloUsuario>();
                objList = c.getUsuario();
                this.txtLits.Text = "consulta generada =)";
                foreach (var i in objList)
                {
                    this.txtLits.Text = i.Nombre;

                }

            }
            catch (Exception exbtnList_Click)
            {
                this.txtLits.Text = exbtnList_Click.Message;
                throw;
            }

        }
    }
}