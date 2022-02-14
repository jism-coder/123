namespace WebApplication1.Modelos
{
    public class UsuarioBase
    {
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string Direccion { get; set; }
        public Nullable<decimal> Telefono { get; set; }
        public string RFC { get; set; }
    }
}