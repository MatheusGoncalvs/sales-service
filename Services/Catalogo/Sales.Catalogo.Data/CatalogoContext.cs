using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales.Catalogo.Domain;
using Sales.Core.Data;

namespace Sales.Catalogo.Data
{
    public class CatalogoContext : DbContext, IUnitOfWork
    {

        public CatalogoContext(DbContextOptions<CatalogoContext> options)
            : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public Task<bool> Commit()
        {
            throw new System.NotImplementedException();
        }
    }
}