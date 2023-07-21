using Domain_Driven_Design__DDD_.Domain.Entities;
using Domain_Driven_Design__DDD_.Domain.Repositories;
using Domain_Driven_Design__DDD_.Domain.Services;
using Domain_Driven_Design__DDD_.Domain.ValueObjects;

namespace Domain_Driven_Design__DDD_.Application.Productos
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _productoRepository;


        public ProductoService(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public Producto CrearProducto(string nombre, Precio precio, Descripcion descripcion)
        {
            var producto = new Producto
            {
                Nombre = nombre,
                Precio = precio,
                Descripcion = descripcion
            };

            return _productoRepository.AgregarProducto(producto);
        }

        public IEnumerable<Producto> ObtenerTodosLosProductos()
        {
            return _productoRepository.ObtenerTodosLosProductos();
        }
    }
}
