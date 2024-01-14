using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=UsuarioGrupo;
            Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=True;
            Encrypt=False;TrustServerCertificate=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Grupos
            modelBuilder.Entity<Grupo>().HasKey(o => o.IdGrupo);
            modelBuilder.Entity<Grupo>().HasIndex(o => o.Nombre).IsUnique();
            modelBuilder.Entity<Grupo>().Property(o => o.Descripcion).IsRequired(false);
            modelBuilder.Entity<Grupo>().Property(o => o.EstaHabilitado).HasDefaultValue(false);

            // Usuarios
            modelBuilder.Entity<Usuario>().HasKey(o => o.IdUsuario);
            modelBuilder.Entity<Usuario>().HasIndex(o => o.Email).IsUnique();
            modelBuilder.Entity<Usuario>().Property(o => o.CantidadIntentos).HasDefaultValue(5);
            modelBuilder.Entity<Usuario>().Property(o => o.EstaAutenticado).HasDefaultValue(false);
            modelBuilder.Entity<Usuario>().Property(o => o.EstaHabilitado).HasDefaultValue(false);

            //UsuarioGrupo
            modelBuilder.Entity<Usuario>().HasMany<Grupo>("Grupos").WithMany("Usuarios").UsingEntity(j => j.ToTable("UsuarioGrupo"));
        }
    }
}
