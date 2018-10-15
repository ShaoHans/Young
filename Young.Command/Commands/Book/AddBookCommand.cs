using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Command.Commands.Book
{
    public class AddBookCommand: IRequest<bool>
    {
        public string Name { get; }

        public string Author { get; }

        public decimal Price { get; }

        public DateTime PubDate { get; }

        public AddBookCommand(string name, string author, decimal price, DateTime pubDate)
        {
            Name = name;
            Author = author;
            Price = price;
            PubDate = pubDate;
        }
    }
}
