using Domain_Driven_Design__DDD_.Domain.ValueObjects;

namespace Domain_Driven_Design__DDD_.Domain.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Precio Precio { get; set; }
        public Descripcion Descripcion { get; set; }
    }


}
