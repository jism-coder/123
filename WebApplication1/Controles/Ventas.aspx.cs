using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class Ventas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(this.txtcantidad.Text);
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(this.txtfecha.Text);


            bool crear = false;
            txtproducto.Text = this.txtproducto.Text;
            ModeloVentas obj = new ModeloVentas();
            obj.Producto = this.txtproducto.Text;
            obj.Usuario = this.txtusuario.Text;
            obj.Fecha = fecha;
            obj.Cantidad = cantidad;
            obj.Total = this.txttotal.Text;
            obj.Forma_Pago = this.txtfp.Text;

            crear = Funciones.Funciones.Ventas(obj);
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