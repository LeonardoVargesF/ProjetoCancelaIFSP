using System.IO;
using AutoMapper;
using CancelaIFSP.App.Cadastros;
using CancelaIFSP.App.Models;
using CancelaIFSP.Domain.Base;
using CancelaIFSP.Domain.Entities;
using CancelaIFSP.Repository.Context;
using CancelaIFSP.Repository.Repository;
using CancelaIFSP.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;


namespace CancelaIFSP.App.Infra
{
    [System.Runtime.Versioning.SupportedOSPlatform("windows")]
    public static class ConfigureDI
    {
        public static ServiceCollection Services;

        public static ServiceProvider ServicesProvider;

        public static void ConfiguraServices()
        {
            Services = new ServiceCollection();
            Services.AddDbContext<MySqlContext>(options =>
            {
                var strCon = File.ReadAllText("Config/DataBaseSettings.txt");
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                options.EnableSensitiveDataLogging();


                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);

                });
            });

            // Repositories
            Services.AddScoped<IBaseRepository<Usuario>, BaseRepository<Usuario>>();
            Services.AddScoped<IBaseRepository<Carro>, BaseRepository<Carro>>();
            Services.AddScoped<IBaseRepository<Tag>, BaseRepository<Tag>>();
            Services.AddScoped<IBaseRepository<UsuarioCarro>, BaseRepository<UsuarioCarro>>();

            // Services
            Services.AddScoped<IBaseService<Usuario>, BaseService<Usuario>>();
            Services.AddScoped<IBaseService<Carro>, BaseService<Carro>>();
            Services.AddScoped<IBaseService<Tag>, BaseService<Tag>>();
            Services.AddScoped<IBaseService<UsuarioCarro>, BaseService<UsuarioCarro>>();


            // Formulários

            Services.AddTransient<CadastroCarro, CadastroCarro>();
            Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroTag, CadastroTag>();
            Services.AddTransient<CadastroUsuarioCarro, CadastroUsuarioCarro>();

            // Mapping
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Usuario, UsuarioModel>();
                config.CreateMap<Carro, CarroModel>()
                    .ForMember(d => d.ModCorAno, d => d.MapFrom(x => $"{x.Modelo} {x.Cor} {x.Ano}"));
                config.CreateMap<Tag, TagModel>()
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => $"{x.Usuario!.Nome}"))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id));
                config.CreateMap<UsuarioCarro, UsuarioCarroModel>()
                    .ForMember(d => d.Usuario, d => d.MapFrom(x => $"{x.Usuario!.Nome}"))
                    .ForMember(d => d.IdUsuario, d => d.MapFrom(x => $"{x.Usuario!.Id}"))
                    .ForMember(d => d.Carro, d => d.MapFrom(x => $"{x.Usuario!.Nome}"))
                    .ForMember(d => d.IdCarro, d => d.MapFrom(x => $"{x.Usuario!.Id}"));
            }).CreateMapper());

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}
