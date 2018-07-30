using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Young.Application;
using Young.Application.Dtos;

namespace Young.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
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
        public IActionResult Create(BookAddDto dto)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var result = _bookService.AddBook(dto);
            if(result)
            {
                return RedirectToAction("index");
            }
            return View();
        }
    }
}