using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Young.Domain.Models;

namespace Young.Domain.Repositories
{
    public interface IUnitOfWork
    {
        //IRepository<T> GetRepository<T>() where T :class, IEntity, IAggregateRoot;

        void SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
