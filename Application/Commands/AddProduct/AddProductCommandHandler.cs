using Application.DTOs.Requests;
using Domain.Aggregates.ProductAggregate;
using Infrastructure.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.CQRS.Commands;

namespace Application.Commands.AddProduct
{
    public class AddProductCommandHandler : ICommandHandler<AddProductCommand>
    {
        private readonly IProductRepository productRepository; 
        public AddProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<CommandResult> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await this.productRepository.AddAsync(new Product(request.title, request.quantity));
            return new CommandResult
            {
                IsSuccess = true,
                Message = "Executed"
            };
        }
    }
}
