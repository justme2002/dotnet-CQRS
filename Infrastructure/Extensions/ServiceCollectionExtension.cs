using Domain.Aggregates.ProductAggregate;
using Domain.Seedworks;
using Infrastructure.Base;
using Infrastructure.Database;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.CQRS.Commands;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddMediator(this IServiceCollection service, Assembly assembly)
        {
            service.AddMediatR(config => config.RegisterServicesFromAssemblies(assembly));
            service.AddScoped<ICommandBus, CommandBus>();
            return service;
        }

        public static IServiceCollection AddDatabase(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlServer"), b => b.MigrationsAssembly("Infrastructure"));
            });
            return service;
        }

        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped((Func<IServiceProvider, Func<AppDbContext>>)((provider) => () => provider.GetService<AppDbContext>()));
            service.AddScoped<IProductRepository, ProductRepository>();
            return service;
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection service)
        {
            return service.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
