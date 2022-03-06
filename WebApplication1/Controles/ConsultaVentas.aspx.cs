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


        }
    }
}