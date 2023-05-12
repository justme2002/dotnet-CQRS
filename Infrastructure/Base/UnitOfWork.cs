using Domain.Seedworks;
using Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        protected AppDbContext DbContext { get; set; }
        public UnitOfWork(AppDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public async Task saveChangeAsync(Func<Task> action)
        {
            await action();
            await this.DbContext.SaveChangesAsync();
        }
    }
}
