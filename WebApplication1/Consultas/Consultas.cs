using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Modelos;

namespace WebApplication1.Consultas
{
    public class Consultas
    {

            public ModeloProductos get1Producto(int pK_producto)
            {

                ModeloProductos r = new ModeloProductos();
                ventas1Entities2 db = new ventas1Entities2();
                #region Consulta Linq 

                var Query = (from a in db.Productos
                             where a.PK_Producto == pK_producto
                             select new ModeloProductos
                             {
                                 Producto = a.Producto,
                                 Descripcion = a.Descripcion,
                                 Disponibilidad = a.Disponibilidad,
                                 Precio = a.Precio,
                                 Cantidad = a.Cantidad.Value
                             }).FirstOrDefault();
                if (Query != null)
                {
                    r = Query;
                }
                #endregion
                return r;
            }

      


    }
}