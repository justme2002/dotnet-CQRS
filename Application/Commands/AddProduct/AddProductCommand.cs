using Application.DTOs.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.CQRS.Commands;

namespace Application.Commands.AddProduct
{
    public class AddProductCommand : ICommand
    {
        public string title { get; set; }
        public int quantity { get; set; }

    }
}
