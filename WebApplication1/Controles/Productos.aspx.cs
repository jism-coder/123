﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Modelos;

namespace WebApplication1.Controles
{
    public partial class Productos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnenviar_Click(object sender, EventArgs e)
        {
            int cantidad = Int32.Parse(this.txtcantidad.Text);
            
            bool crear = false;
            txtenviar.Text = this.txtproducto.Text;
            ModeloProductos obj = new ModeloProductos();
            obj.Producto = this.txtproducto.Text;
            obj.Descripcion = this.txtdescripcion.Text;
            obj.Disponibilidad = this.txtdispo.Text;
            obj.Precio = this.txtprecio.Text;
            obj.Cantidad = cantidad;

            crear = Funciones.Funciones.Productos(obj);
            if (crear ==false)
            {
                txtenviar.Text= "El usuario no se creo correctamnete";
            }
            else
            {
                txtenviar.Text = "El usuario se creo correctamente";

            }
        }

    }
}