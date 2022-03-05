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
            public List<ModeloProductos> getProductos()
            {
                List<ModeloProductos> r = new List<ModeloProductos>();

                ventas1Entities2 db = new ventas1Entities2();

                var Query = (from a in db.Productos
                             where a.PK_Producto > 0
                             select new ModeloProductos
                             {
                                 pk_producto =a.PK_Producto,
                                 Producto = a.Producto,
                                 Descripcion = a.Descripcion,
                                 Disponibilidad = a.Disponibilidad,
                                 Precio = a.Precio,
                                 Cantidad = a.Cantidad.Value
                             }).ToList();
                if (Query.Count > 0)
                {
                    foreach (var i in Query)
                    {
                        r.Add(new ModeloProductos
                        {
                            pk_producto = i.pk_producto,
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
            public List<ModeloUsuario> getUsuario()
            {
                List<ModeloUsuario> r = new List<ModeloUsuario>();

                ventas1Entities2 db = new ventas1Entities2();

                var Query = (from a in db.Usuario
                             where a.PK_Usuarios > 0
                             select new ModeloUsuario
                             {
                                PK_Usuarios = a.PK_Usuarios,
                                Nombre = a .Nombre,
                                Apellido_Paterno= a.Apellido_Paterno,
                                Apellido_Materno = a.Apellido_Materno,
                                Direccion = a.Direccion,
                                //tel = a.Telefono.Value != null?a.Telefono.Value:decimal.MinValue,
                                RFC = a .RFC,

                      
                             }).ToList();
                if (Query.Count > 0)
                {
                    foreach (var i in Query)
                    {
                        r.Add(new ModeloUsuario
                        {
                           PK_Usuarios = i.PK_Usuarios,
                           Nombre =i.Nombre,
                           Apellido_Paterno =i.Apellido_Paterno,
                           Apellido_Materno = i.Apellido_Materno,
                           Direccion =i.Direccion,
                           tel =i.tel,
                           RFC=i.RFC

                        }); ;
                    }
                }
                return r;
            }
            public List<ModeloVentas> getVentas()
            {
                List<ModeloVentas> r = new List<ModeloVentas>();

                ventas1Entities2 db = new ventas1Entities2();

                var Query = (from a in db.Ventas
                             where a.PK_Ventas > 0
                             select new ModeloVentas
                             {
                                 pk_ventas = a.PK_Ventas,
                                 Producto = a.Producto,
                                 Cantidad = a.Cantidad.Value,
                                 Usuario = a.Usuario,
                                 Fecha = a. Fecha.Value,
                                 Forma_Pago = a.Forma_Pago ,
                                 Total= a.Total,
                            
                             }).ToList();
                if (Query.Count > 0)
                {
                    foreach (var i in Query)
                    {
                        r.Add(new ModeloVentas
                        {
                            pk_ventas = i.pk_ventas,
                            Producto = i.Producto,
                            Cantidad = i.Cantidad,
                            Usuario = i.Usuario,
                            Fecha = i.Fecha,
                            Forma_Pago= i.Forma_Pago,
                            Total = i.Total

                        }); 
                    }
                }
                return r;
            }




    }
}