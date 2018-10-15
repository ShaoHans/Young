using System;
using System.Collections.Generic;
using System.Text;
using Young.Application.ViewModels;

namespace Young.Application
{
    public interface IBookQuery
    {
        List<BookViewModel> GetAll();
    }
}
