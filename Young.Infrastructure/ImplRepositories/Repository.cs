using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Young.Domain.Models;
using Young.Domain.Repositories;

namespace Young.Infrastructure.ImplRepositories
{
    public class Repository<T> : IRepository<T> where T :class, IAggregateRoot
    {
        private AppDbContext _dbContext;

        public Repository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(T entity)
        {
            _dbContext.Add(entity);
            return true;
        }

        public IList<T> GetAll(Expression<Func<bool, bool>> expressions)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            return _dbContext.Find<T>(id);
        }

        public bool Update(T entity)
        {
            _dbContext.Update(entity);
            return true;
        }
    }
}
