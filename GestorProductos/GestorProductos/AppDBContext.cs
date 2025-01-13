using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GestorProductos
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }
        public DbSet<Producto> Productos { get; set; }

        public class Producto
        {
            public int Id { get; set; }
            public string? Nombre { get; set; }
            public string? Descripcion { get; set; }
            public decimal Precio { get; set; }
            public int Stock { get; set; }
        }
    }
    
    
}
