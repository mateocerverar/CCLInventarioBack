namespace WebAPI.DTOs
{
    public class MovimientoDTO
    {
        public int IdProducto { get; set; }
        public string Tipo { get; set; } // "entrada" o "salida"
        public int Cantidad { get; set; }
    }
}
