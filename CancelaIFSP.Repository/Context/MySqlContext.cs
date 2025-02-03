using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Repository.Mapping;
using Microsoft.EntityFrameworkCore;

namespace CancelaIFSP.Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Carro>? Carro { get; set; }
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<UsuarioCarro>? UsuarioCarro { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Carro>(new CarroMap().Configure);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<UsuarioCarro>(new UsuarioCarroMap().Configure);

        }
    }
}
