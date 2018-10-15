using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;
using Young.Domain.Repositories;

namespace Young.Infrastructure.Repositories
{
    public class EfCoreRepositoryBase<TEntity> :  EfCoreRepositoryBase<TEntity, int>, IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        public EfCoreRepositoryBase(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
