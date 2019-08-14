using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<UsuarioGrupo> UsuarioGrupos { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        //Exemplo Fluent API: 

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity => {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Nome)
                      .IsRequired()
                      .HasMaxLength(400);

            });
            base.OnModelCreating(modelBuilder);
        }
        */
    }
}
