using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Young.Domain.Models;
using Young.Domain.Repositories;

namespace Young.Infrastructure.Repositories
{
    public class EfCoreUnitOfWork : IUnitOfWork
    {
        private AppDbContext _dbContext;

        public EfCoreUnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public IRepository<T> GetRepository<T>() where T :class, IEntity, IAggregateRoot
        //{
        //    return new EfCoreRepositoryBaseOfTEntityAndTPrimaryKey<T>(_dbContext);
        //}

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
