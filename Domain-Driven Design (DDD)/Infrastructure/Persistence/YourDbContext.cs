using Domain_Driven_Design__DDD_.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Domain_Driven_Design__DDD_.Infrastructure.Persistence
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.OwnsOne(p => p.Precio, precio =>
                {
                    precio.Property(p => p.Valor).HasColumnName("Valor");
                    precio.Property(p => p.Moneda).HasColumnName("Moneda");
                });

                entity.OwnsOne(p => p.Descripcion, descripcion =>
                {
                    descripcion.Property(d => d.Contenido).HasColumnName("Contenido");
                });
            });
        }
    }
}
