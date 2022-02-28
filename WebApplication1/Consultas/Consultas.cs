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

            public ModeloVentas get1Ventas(int pK_ventas)
            {

                ModeloVentas r = new ModeloVentas();
                ventas1Entities2 db = new ventas1Entities2();
                #region Consulta Linq 

                var Query = (from a in db.Ventas
                             where a.PK_Ventas == pK_ventas
                             select new ModeloVentas
                             {
                                Producto = a.Producto,
                                Cantidad = a.Cantidad.Value,
                                Usuario = a.Usuario,
                                Fecha = a.Fecha.Value,
                                Forma_Pago =a.Forma_Pago,
                                Total = a.Total,
                             }).FirstOrDefault();
                if (Query != null)
                {
                    r = Query;
                }
                #endregion
                return r;
            }
            public ModeloUsuario get1Usuario(int pK_usuario)
            {

                ModeloUsuario r = new ModeloUsuario();
                ventas1Entities2 db = new ventas1Entities2();
            #region Consulta Linq 

            var Query = (from a in db.Usuario
                         where a.PK_Usuarios == pK_usuario
                         select new ModeloUsuario
                         {
                             Nombre = a.Nombre,
                             Apellido_Paterno = a.Apellido_Paterno,
                             Apellido_Materno = a.Apellido_Materno,
                             Direccion = a.Direccion,
                             Telefono = (int)a.Telefono,
                             RFC =a.RFC

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