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
        private readonly IRepositoryContext _repositoryContext;

        public BookService(IRepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public bool AddBook(BookAddDto dto)
        {
            try
            {
                _repositoryContext.BeginTransaction();
                var bookRepository = _repositoryContext.GetRepository<Book>();
                Book book = new Book();
                book.Name = dto.Name;
                book.Author = dto.Author;
                book.Price = dto.Price;
                book.PubDate = dto.PubDate;
                book.Status = BorrowStatus.UnBorrow;
                bookRepository.Add(book);
                return _repositoryContext.Commit();
            }
            catch (Exception ex)
            {
                _repositoryContext.Rollback();
                return false;
            }
        }
    }
}
