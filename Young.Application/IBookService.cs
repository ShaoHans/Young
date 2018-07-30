using System;
using System.Collections.Generic;
using System.Text;
using Young.Application.Dtos;

namespace Young.Application
{
    public interface IBookService
    {
        bool AddBook(BookAddDto dto);
    }
}
