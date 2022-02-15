using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Modelos;

namespace WebApplication1.Funciones
{
    public class Funciones
    {
        public static bool Usuario(ModeloUsiario obj)
        {
            bool respuesta = false;
            try
            {
                ventas1Entities db = new ventas1Entities();
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
    }
}