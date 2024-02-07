using Microsoft.Extensions.DependencyInjection;
using ProjetoModelo.Application.CommandHandlers;
using ProjetoModelo.Application.Mapper;
using ProjetoModelo.Application.QuerieHandlers;
using ProjetoModelo.Domain.Interfaces;
using ProjetoModelo.Infrastructure.Data.Repositories;

namespace ProjetoModelo.Infrastructure.IoC
{
    public static class Configuration
    {
        public static IServiceCollection InfrastructureDependencies(this IServiceCollection services)
        {

            // Configuração dos Repositórios
            services.AddScoped<IPessoaRepository, PessoaRepository>();

            // Configuração dos Manipuladores de Eventos
            services.AddTransient<PessoaCommandHandler>();
            services.AddTransient<PessoaQueryHandler>();

            services.AddTransient<PessoaMapper>();

            return services;

        }
    }
}
