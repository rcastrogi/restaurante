using Microsoft.EntityFrameworkCore;
using RestauranteApi.DAL.Entidades;

namespace RestauranteApi.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        public DbSet<Restaurante> Restaurante { get; set; }

        public DbSet<Prato> Prato { get; set; }
        
    }
}
