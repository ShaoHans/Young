using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Young.Application;
using Young.Application.Dtos;
using Young.Command.Commands.Book;

namespace Young.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BookAddDto dto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var result = await _mediator.Send(new AddBookCommand(dto.Name, dto.Author, dto.Price, DateTime.Now));
            if(result)
            {
                RedirectToAction("index");
            }
            return View();
        }
    }
}