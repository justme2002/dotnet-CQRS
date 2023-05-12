using Application.Commands.AddProduct;
using Application.Commands.GetAllProduct;
using Application.DTOs.Requests;
using Domain.Aggregates.ProductAggregate;
using Infrastructure.Extensions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceCollectionExtension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddCqrs (this IServiceCollection service)
        {
            //service.AddScoped<IRequest<AddProductRequest>, AddProductCommand>();
            //service.AddScoped<IRequestHandler<AddProductCommand, AddProductRequest>, AddProductCommandHandler>();
            service.AddMediator(Assembly.GetExecutingAssembly());
            return service;
        }

        public static IServiceCollection AddQuery(this IServiceCollection service)
        {
            service.AddScoped<IRequest<IList<Product>>, GetAllProductQuery>();
            service.AddScoped<IRequestHandler<GetAllProductQuery, List<Product>>, GetAllProductQueryHandler>();
            return service;
        }
    }
}
