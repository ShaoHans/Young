using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Young.Application;
using Young.Application.ViewModels;
using Young.Command.Commands.Book;

namespace Young.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IBookQuery _bookQuery;

        public BookController(IMediator mediator,IBookQuery bookQuery)
        {
            _mediator = mediator;
            _bookQuery = bookQuery;
        }

        public IActionResult Index()
        {
            return View(_bookQuery.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookViewModel dto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var result = await _mediator.Send(new AddBookCommand(dto.Name, dto.Author, dto.Price, DateTime.Now));
            if(result)
            {
                return RedirectToAction("index");
            }
            return View();
        }
    }
}