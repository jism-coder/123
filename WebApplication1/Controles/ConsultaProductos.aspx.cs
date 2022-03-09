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

            txtPK_Producto.Text = obj.Pk_Producto.ToString();
            txtProducto.Text = obj.Producto;
            txtProducto.Visible = true;

            txtDescripción.Text = obj.Descripcion;
            txtDescripción.Visible = true;

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

            txtDescripción.Text = "";
            txtDescripción.Visible = false;

            txtDisponibilidad.Text = "";
            txtDisponibilidad.Visible = false;

            txtPrecio.Text = "";
            txtPrecio.Visible = false;

            txtCantidad.Text = "";
            txtCantidad.Visible = false;
        }

        protected void btnActualizarRegistro_Click(object sender, EventArgs e)
        {
            ModeloProductos obj = new ModeloProductos();
            int pk = Int32.Parse(this.txtPK_Producto.Text);
            obj.Pk_Producto = pk;
            int cantidad = Int32.Parse(txtCantidad.Text);
            obj.Producto = txtProducto.Text;
            obj.Descripcion = txtDescripción.Text;
            obj.Disponibilidad = txtDisponibilidad.Text;
            obj.Precio = txtPrecio.Text;
            obj.Cantidad = cantidad;


            Consultas.Consultas c = new Consultas.Consultas();


            c.actualizaRegistro(obj);

        }


    }
}