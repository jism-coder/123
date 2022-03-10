using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class ConsultaProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getProductos();
        }
        protected void getProductos()
        {
            List<ModeloProductos> query = new List<ModeloProductos>();
            Consultas.Consultas c = new Consultas.Consultas();
            query = c.getProductos();

            if (query.Count > 0)
            {
                idGvProductos.AllowPaging = true;

                idGvProductos.DataSource = query;

                idGvProductos.DataBind();
            }
        }

        protected void ComandRowProducto(object sender, GridViewCommandEventArgs e)
        {
            int nRowIndex = Int32.Parse(e.CommandArgument.ToString());
            string pk = idGvProductos.DataKeys[nRowIndex].Value.ToString();
            int valor = int.Parse(pk);
            
            Consultas.Consultas c = new Consultas.Consultas();
            ModeloProductos obj = new ModeloProductos();
            obj = c.get1Producto(valor);

            txtPK_Producto.Text = obj.pk_producto.ToString();
            txtProducto.Text = obj.Producto;
            txtProducto.Visible = true;

            txtDescripcion.Text = obj.Descripcion;
            txtDescripcion.Visible = true;

            txtDisponibilidad.Text = obj.Disponibilidad;
            txtDisponibilidad.Visible = true;

            txtPrecio.Text = obj.Precio;
            txtPrecio.Visible = true;

            txtCantidad.Text = obj.Cantidad.ToString();
            txtCantidad.Visible = true;


        }

        protected void btnConsultaProducto_Click(object sender, EventArgs e)
        {
            txtProducto.Text = "";
            txtProducto.Visible = false;

            txtDescripcion.Text="";
            txtDescripcion.Visible = false;

            txtDisponibilidad.Text = "";
            txtDisponibilidad.Visible = false;

            txtPrecio.Text = "";
            txtPrecio.Visible = false;

            txtCantidad.Text = "";
            txtCantidad.Visible = false;

        }       

        protected void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(txtCantidad.Text);
            int pk = Int32.Parse(txtPK_Producto.Text);        
          
            ModeloProductos obj = new ModeloProductos();
            Consultas.Consultas c = new Consultas.Consultas();
            
            obj.pk_producto = pk;
            obj.Producto = txtProducto.Text;
            obj.Descripcion = txtDescripcion.Text;
            obj.Disponibilidad = txtDisponibilidad.Text;
            obj.Precio = txtPrecio.Text;
            obj.Cantidad = cantidad;

            c.actualizaRegistro(obj);
        }
    }
}  
