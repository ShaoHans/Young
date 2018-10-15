using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Young.Domain.Models;
using Young.Domain.Repositories;

namespace Young.Command.Commands.Book
{
    public class AddBookCommandHandler : IRequestHandler<AddBookCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<Domain.Models.Book> _bookRepository;

        public AddBookCommandHandler(IUnitOfWork unitOfWork, IRepository<Domain.Models.Book> bookRepository)
        {
            _unitOfWork = unitOfWork;
            _bookRepository = bookRepository;
        }

        public async Task<bool> Handle(AddBookCommand request, CancellationToken cancellationToken)
        {
            Domain.Models.Book book = new Domain.Models.Book();
            book.Name = request.Name;
            book.Price = request.Price;
            book.Author = request.Author;
            book.PubDate = request.PubDate;
            book.Status = BorrowStatus.Borrowing;
            _bookRepository.Insert(book);
            return await _unitOfWork.SaveChangesAsync() > 0;
        }
    }
}
