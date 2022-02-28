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
        Consultas.Consultas c = new Consultas.Consultas();
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

        protected void bto1Venta_Click(object sender, EventArgs e)
        {
            int ventas = int.MaxValue;
            try
            {
               
                ventas = int.Parse(this.txboxQueVenta.Text);
                ModeloVentas objVenta = new ModeloVentas();
                objVenta = c.get1Ventas(ventas);
                txtResultadoQueVenta.Text = objVenta.Producto + "|" + objVenta.Cantidad + "|" + objVenta.Usuario;

            }
            catch (Exception exbto1Venta_Click)

            {
                this.txtenviar.Text = exbto1Venta_Click.Message;
                throw;
            }
        }

        protected void btnList_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtLits.Text = "procesando...";
                List<ModeloVentas> objList = new List<ModeloVentas>();
                objList = c.getVentas();
                this.txtLits.Text = "consulta generada =)";
                foreach (var i in objList)
                {
                    this.txtLits.Text = i.Producto;

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