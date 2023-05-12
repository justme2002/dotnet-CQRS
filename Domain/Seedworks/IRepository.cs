using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Seedworks
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        List<T> Get();
    }
}
