using System;
using System.Collections.Generic;
using System.Text;
using Young.Application.Dtos;
using Young.Domain.Models;
using Young.Domain.Repositories;

namespace Young.Application.Impl
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _repositoryContext;

        public BookService(IUnitOfWork repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public bool AddBook(BookAddDto dto)
        {
            return true;
        }
    }
}
