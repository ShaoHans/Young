using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Application.Dtos
{
    public class BookAddDto
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime PubDate { get; set; }

    }
}
