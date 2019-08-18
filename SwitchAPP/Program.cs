using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Infra.CrossCutting.Logging;
using Switch.Infra.Data.Context;
using System;
using System.Collections.Generic;

namespace SwitchAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1;
            Usuario usuario2;
            Usuario usuario3;
            Usuario usuario4;
            Usuario usuario5;
            Usuario usuario6;

            Usuario CriarUsuario(string nome)
            {
                return new Usuario()
                {
                    Nome = "Usuario1",
                    SobreNome = "SobreNomeUsuario1",
                    Senha = "123456",
                    Email = "user_teste@gmail.com",
                    DataNascimento = DateTime.Now,
                    Sexo = Switch.Domain.Enums.SexoEnum.Masculino,
                    UrlFoto = @"C:\temp"
                };
            }

             usuario1 = CriarUsuario("usuario1");
             usuario2 = CriarUsuario("usuario2");
             usuario3 = CriarUsuario("usuario3");
             usuario4 = CriarUsuario("usuario4");
             usuario5 = CriarUsuario("usuario5");
             usuario6 = CriarUsuario("usuario6");

            List<Usuario> usuarios = new List<Usuario>() { usuario1, usuario2, usuario3, usuario4, usuario5, usuario6};

            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=NsaentndbtdM2019**;database=SwitchDB;", m => m.MigrationsAssembly("Switch.Infra.Data"));

            try
            {
                using (var dbcontext = new SwitchContext(optionsBuilder.Options))
                {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());
                    dbcontext.Usuarios.AddRange(usuarios);
                    dbcontext.SaveChanges();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }

            Console.WriteLine("Salvo com sucesso!");
            Console.ReadKey();
            

        }
    }
}
