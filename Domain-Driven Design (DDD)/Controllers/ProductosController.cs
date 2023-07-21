using Domain_Driven_Design__DDD_.Domain.Entities;
using Domain_Driven_Design__DDD_.Domain.Services;
using Domain_Driven_Design__DDD_.Domain.ValueObjects;
using Domain_Driven_Design__DDD_.Presentation.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Domain_Driven_Design__DDD_.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;
        
        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }
        [HttpPost]
        public IActionResult CrearProducto([FromBody] ProductoViewModel productoViewModel)
        {
            var precio = new Precio
            {
                Valor = productoViewModel.Valor,
                Moneda = productoViewModel.Moneda
            };

            var descripcion = new Descripcion
            {
                Contenido = productoViewModel.Descripcion
            };

            var producto = _productoService.CrearProducto(productoViewModel.Nombre, precio, descripcion);

            var responseViewModel = new ProductoViewModel
            {
                Id = producto.Id,
                Nombre = productoViewModel.Nombre,
                Descripcion = producto.Descripcion.Contenido
            };

            return Ok(responseViewModel);
        }

        [HttpGet]
        public IActionResult ObtenerTodosLosProductos() 
        {
            var productos = _productoService.ObtenerTodosLosProductos();

            var responseViewModels = productos.Select(productos => new ProductoViewModel
            {
                Id = productos.Id,
                Nombre = productos.Nombre,
                Valor = productos.Precio.Valor,
                Moneda = productos.Precio.Moneda,
                Descripcion = productos.Descripcion.Contenido
            });

            return Ok(responseViewModels);  
           
        }

    }
}
