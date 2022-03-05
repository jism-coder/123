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
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}