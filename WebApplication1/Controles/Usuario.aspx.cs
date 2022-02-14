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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            bool crear = false;
            txtenviar.Text = this.txtnombre.Text;
            ModeloUsiario obj = new ModeloUsiario();
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
                txtenviar.Text = "El usuario no se creo correctamnete";
            }
            else
            {
                txtenviar.Text = "El usuario se creo correctamente";

            }



        }


    }
}