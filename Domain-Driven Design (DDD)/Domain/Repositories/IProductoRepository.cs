using Domain_Driven_Design__DDD_.Domain.Entities;
using Domain_Driven_Design__DDD_.Domain.ValueObjects;

namespace Domain_Driven_Design__DDD_.Domain.Repositories
{
    public interface IProductoRepository
    {
        Producto AgregarProducto(Producto producto);
        IEnumerable<Producto> ObtenerTodosLosProductos();
    }
}
