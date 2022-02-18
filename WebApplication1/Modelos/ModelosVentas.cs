using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Modelos
{
    public class ModeloUsuario
    {
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Direccion { get; set; }
        public Nullable<decimal> Telefono { get; set; }
        public string RFC { get; set; }
    }
    public class ModeloProductos
    {
        public string Producto { get; set; }
        public string Descripcion { get; set; }
        public string Disponibilidad { get; set; }
        public string Precio { get; set; }
        public int Cantidad { get; set; }
        public string Total { get; set; }
     
    }
    public class ModeloVentas
    {
        public string Producto { get; set; }
        public string Usuario { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Forma_Pago { get; set; }
        public string Total { get; set; }

    }
}