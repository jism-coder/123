using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Modelos;

namespace WebApplication1.Consultas
{
    public class Consultas
    {
        public ModeloProductos get1Producto(int pk_producto)
        {
            ModeloProductos r = new ModeloProductos();
            ventas1Entities2 db = new ventas1Entities2();
            #region Consulta Linq 

            var Query = (from a in db.Productos
                         where a.PK_Producto == pk_producto
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
        public List<ModeloProductos> getProductos()
        {
            List<ModeloProductos> r = new List<ModeloProductos>();

            ventas1Entities2 db = new ventas1Entities2();

            var Query = (from a in db.Productos
                         where a.PK_Producto > 0
                         select new ModeloProductos
                         {
                             Pk_Producto = a.PK_Producto,
                             Producto = a.Producto,
                             Descripcion = a.Descripcion,
                             Disponibilidad = a.Disponibilidad,
                             Precio = a.Precio,
                             Cantidad = a.Cantidad.Value
                         }).ToList();
            if (Query.Count > 0)
            {
                foreach(var i in Query)
                {
                    r.Add(new ModeloProductos
                    {
                        Pk_Producto = i.Pk_Producto,
                        Producto = i.Producto,
                        Descripcion = i.Descripcion,
                        Disponibilidad = i.Disponibilidad,
                        Precio = i.Precio,
                        Cantidad = i.Cantidad,
                    }); ;
                }
            }
            return r;
        }


    }
}