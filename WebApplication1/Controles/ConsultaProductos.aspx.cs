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
    }
}