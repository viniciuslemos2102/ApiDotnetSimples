using ApiDotenet.Robusta.Application.Mappings;
using ApiDotenet.Robusta.Application.Services;
using ApiDotenet.Robusta.Application.Services.Interfaces;
using ApiDotnetRobusta.Domain.Context;
using ApiDotnetRobusta.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotnet.Robusta.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseNpgsql(configuration.GetConnectionString("")));

            services.AddScoped<IPersonRepository, IPersonRepository>();
            return services;
        }

        public static IServiceCollection AddService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DomainToDTOMapping));
            services.AddScoped<IPersonServices, PersonServices>();
            return services;
        }
    }
}
