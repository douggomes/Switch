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
        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Identificacao> Identificacaos { get; set; }
        public DbSet<InstituicaoEnsino> InstituicoesEnsino { get; set; }
        public DbSet<LocalTrabalho> LocaisTrabalho { get; set; }
        public DbSet<ProcurandoPor> ProcurandoPor { get; set; }

        public SwitchContext(DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new PostagemConfiguration());
            modelBuilder.ApplyConfiguration(new GrupoConfiguration());
            modelBuilder.ApplyConfiguration(new UsuarioGrupoConfiguration());
            modelBuilder.ApplyConfiguration(new AmigoConfiguration());
            modelBuilder.ApplyConfiguration(new ComentarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProcurandoPorConfiguration());
            modelBuilder.ApplyConfiguration(new StatusRelacionamentoConfiguration());


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
