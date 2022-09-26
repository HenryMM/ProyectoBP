using App.BP.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;

namespace App.BP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Cliente>()
            //    .HasMany(b => b.Cuentas)
            //    .WithOne()
            //    .HasForeignKey(b=>b.ClienteId);

            //modelBuilder.Entity<Cliente>()
            //   .Navigation(b => b.Cuentas)
            //   .UsePropertyAccessMode(PropertyAccessMode.Property);

            //modelBuilder.Entity<Movimiento>().HasOne(e => e.Cuenta);
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }
}