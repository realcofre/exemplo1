using Microsoft.EntityFrameworkCore;

namespace exemplo1.Models
{
    public class Context: DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString:@"Server=127.0.0.1;Port=5432;Database=CursoMVC;User Id=postgres;Password=postgres;");
        }        
    }
}