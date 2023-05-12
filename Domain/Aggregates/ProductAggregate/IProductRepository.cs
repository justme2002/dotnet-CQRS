using Domain.Seedworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates.ProductAggregate
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
