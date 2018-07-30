using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;

namespace Young.Domain.Repositories
{
    public interface IRepositoryContext
    {
        IRepository<T> GetRepository<T>() where T :class, IEntity, IAggregateRoot;

        void BeginTransaction();

        bool Commit();

        void Rollback();
    }
}
