namespace RestauranteSaborCasero.Models
{
    // Representa un producto que aparece en el menú del restaurante.
    public class Plato
    {
        public string Nombre { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public decimal Precio { get; set; }
    }
}
