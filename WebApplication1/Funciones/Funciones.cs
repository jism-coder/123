using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Modelos;

namespace WebApplication1.Funciones
{
    public class Funciones
    {
        public static bool Usuario(ModeloUsuario obj)
        {
            bool respuesta = false;
            try
            {
                ventas1Entities2 db = new ventas1Entities2();
                var tbUsr = new Usuario();
                tbUsr.Nombre = obj.Nombre;
                tbUsr.Apellido_Paterno = obj.Apellido_Paterno;
                tbUsr.Apellido_Materno = obj.Apellido_Materno;
                tbUsr.Direccion = obj.Direccion;
                tbUsr.Telefono = obj.Telefono;
                tbUsr.RFC = obj.RFC;

                db.Usuario.Add(tbUsr);
                db.SaveChanges();
                respuesta = true;
            }
            catch (Exception)
            {

                throw;
            }
            
            return respuesta;
        }
        public static bool Productos(ModeloProductos obj)
        {
            bool respuesta = false;
            try
            {
                ventas1Entities2 db = new ventas1Entities2();
                var tbPrd = new Productos();
                tbPrd.Producto = obj.Producto;
                tbPrd.Descripcion = obj.Descripcion;
                tbPrd.Disponibilidad = obj.Disponibilidad;
                tbPrd.Cantidad = obj.Cantidad;
                tbPrd.Precio = obj.Precio;
           
            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }
        public static bool Ventas(ModeloVentas obj)
        {
            bool respuesta = false;
            try
            {
                ventas1Entities2 db = new ventas1Entities2();
                var tbventas = new Ventas();
                tbventas.Producto = obj.Producto;
                tbventas.Usuario = obj.Usuario;
                tbventas.Forma_Pago = obj.Forma_Pago;
                tbventas.Fecha = obj.Fecha;
                tbventas.Cantidad = obj.Cantidad;
                tbventas.Total = obj.Total;
               

            }
            catch (Exception)
            {

                throw;
            }
            return respuesta;
        }
    }
}