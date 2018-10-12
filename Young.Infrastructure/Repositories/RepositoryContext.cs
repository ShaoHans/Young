using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;
using Young.Domain.Repositories;

namespace Young.Infrastructure.Repositories
{
    public class RepositoryContext : IRepositoryContext
    {
        private AppDbContext _dbContext;

        public RepositoryContext(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void BeginTransaction()
        {
            
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() > 0;
        }

        public IRepository<T> GetRepository<T>() where T :class, IEntity, IAggregateRoot
        {
            return new Repository<T>(_dbContext);
        }

        public void Rollback()
        {
        }
    }
}
