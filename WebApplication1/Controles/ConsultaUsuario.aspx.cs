using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getUsuario();
        }
        protected void getUsuario()
        {
            List<ModeloUsuario> query = new List<ModeloUsuario>();
            Consultas.Consultas c = new Consultas.Consultas();
            query = c.getUsuario();

            if (query.Count > 0)
            {
                idGvUsuarios.AllowPaging = true;

                idGvUsuarios.DataSource = query;

                idGvUsuarios.DataBind();

            }
        }

    }
}