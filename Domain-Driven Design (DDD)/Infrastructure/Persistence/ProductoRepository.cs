using Domain_Driven_Design__DDD_.Domain.Entities;
using Domain_Driven_Design__DDD_.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Domain_Driven_Design__DDD_.Infrastructure.Persistence
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly YourDbContext _dbcontext;

        public ProductoRepository(YourDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Producto AgregarProducto(Producto producto)
        {
            // Implementar lógica para guardar el producto en la base de datos
            _dbcontext.Productos.Add(producto);
            _dbcontext.SaveChanges();
            return producto;
        }

        public IEnumerable<Producto> ObtenerTodosLosProductos()
        {
            return _dbcontext.Productos.ToList();
        }
    }
}