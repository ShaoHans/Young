using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Young.Domain.Models;

namespace Young.Domain.Repositories
{
    public interface IRepository<T> where T: IAggregateRoot
    {
        bool Add(T entity);

        bool Update(T entity);

        T GetById(int id);

        IList<T> GetAll(Expression<Func<bool, bool>> expressions);
    }
}
