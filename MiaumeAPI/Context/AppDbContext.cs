using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MiaumeAPI.Models;
using System.IO;

namespace MiaumeAPI.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<UsuarioPet> UsuarioPet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //------entidade Usuario--------------------
        //    modelBuilder.Entity<Usuario>().HasKey(u => u.CPFCNPJ);
        //    modelBuilder.Entity<Usuario>()
        //        .Property(p => p.nmUsuario)
        //        .HasMaxLength(100)
        //        .IsRequired();

        //    modelBuilder.Entity<Usuario>()
        //         .Property(p => p.telefone)
        //         .HasMaxLength(100)
        //         .IsRequired();

        //    //------entidade UsuarioPet--------------------
        //    modelBuilder.Entity<UsuarioPet>().HasKey(a => a.idPet);
        //    modelBuilder.Entity<UsuarioPet>()
        //        .Property(p => p.nmPet)
        //        .HasMaxLength(200)
        //        .IsRequired();

        //    //um-para-muitos :  Usuario - UsuarioPet
        //    modelBuilder.Entity<UsuarioPet>()
        //      .HasOne<Usuario>(s => s.Usuario)
        //        .WithMany(g => g.UsuarioPets)
        //           .HasForeignKey(s => s.CPFCNPJ);
        //}
    }
}
