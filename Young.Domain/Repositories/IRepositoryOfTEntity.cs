using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;

namespace Young.Domain.Repositories
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {
    }
}
