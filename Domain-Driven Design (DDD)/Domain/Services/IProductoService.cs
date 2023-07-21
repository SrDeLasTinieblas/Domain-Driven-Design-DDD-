using Domain_Driven_Design__DDD_.Domain.Entities;
using Domain_Driven_Design__DDD_.Domain.ValueObjects;

namespace Domain_Driven_Design__DDD_.Domain.Services
{
    public interface IProductoService
    {
        Producto CrearProducto(string nombre, Precio precio, Descripcion descripcion);
        IEnumerable<Producto> ObtenerTodosLosProductos();
    }
}
