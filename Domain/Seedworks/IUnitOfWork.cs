using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Seedworks
{
    public interface IUnitOfWork
    {
        Task saveChangeAsync(Func<Task> action);
    }
}
