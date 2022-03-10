using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class ConsultaVentas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getVentas();
        }
        protected void getVentas()
        {
            List<ModeloVentas> query = new List<ModeloVentas>();
            Consultas.Consultas c = new Consultas.Consultas();
            query = c.getVentas();
           
            if(query.Count > 0)
            {
                idGvVentas.AllowPaging = true;

                idGvVentas.DataSource = query;

                idGvVentas.DataBind();
            }
        }
        protected void ComandRowVentas(object sender, GridViewCommandEventArgs e)
        {
            int nRowIndex = Int32.Parse(e.CommandArgument.ToString());
            string pk = idGvVentas.DataKeys[nRowIndex].Value.ToString();
            int valor = int.Parse(pk);

            Consultas.Consultas c = new Consultas.Consultas();
            ModeloVentas obj = new ModeloVentas();
            obj = c.get1Ventas(valor);

            txtPK_Ventas.Text = obj.pk_ventas.ToString();
            txtProducto.Text = obj.Producto;
            txtProducto.Visible = true;
            
            txtCantidad.Text = obj.Cantidad.ToString();
            txtCantidad.Visible = true;

            txtUsuario.Text = obj.Usuario;
            txtUsuario.Visible = true;

            txtFecha.Text = obj.Fecha.ToString();
            txtFecha.Visible = true;

            txtFormapago.Text = obj.Forma_Pago;
            txtFormapago.Visible = true;

            txtTotal.Text = obj.Total;
            txtTotal.Visible = true;


        }

        protected void btnConsultaVenta_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
            txtProducto.Visible = false;

            txtCantidad.Text = "";
            txtCantidad.Visible = false;

            txtUsuario.Text = "";
            txtUsuario.Visible = false;

            txtFecha.Text = "";
            txtFecha.Visible = false;

            txtFormapago.Text = "";
            txtFormapago.Visible = false;

            txtTotal.Text = "";
            txtTotal.Visible = false;


        }

        protected void btnActualizarRegistroVentas_Click(object sender, EventArgs e)
        {
            int pk = Int32.Parse(txtPK_Ventas.Text);
            int cantidad = Int32.Parse(txtCantidad.Text);
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(this.txtFecha.Text);


            ModeloVentas obj = new ModeloVentas();
            Consultas.Consultas c = new Consultas.Consultas();

            obj.pk_ventas = pk;
            obj.Producto = txtProducto.Text;
            obj.Cantidad = cantidad;
            obj.Usuario = txtUsuario.Text;
            obj.Fecha = fecha;
            obj.Forma_Pago = txtFormapago.Text;
            obj.Total = txtTotal.Text;

            c.actualizaRegistroVentas(obj);

        }
    }
}