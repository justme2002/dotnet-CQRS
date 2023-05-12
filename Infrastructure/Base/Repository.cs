using Domain.Seedworks;
using Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected AppDbContext DbContext { get; set; }
        public Repository(AppDbContext context)
        {
            this.DbContext = context;
        }
        public async Task AddAsync(T entity)
        {
            await this.DbContext.Set<T>().AddAsync(entity);
            await this.DbContext.SaveChangesAsync();
        }

        public List<T> Get()
        {
            return this.DbContext.Set<T>().ToList();
        }
    }
}
