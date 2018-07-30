using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Domain.Models
{
    public class BorrowRecord : IEntity
    {
        public int Id { get; set; }

        public int ReaderId { get; set; }

        public int BookId { get; set; }

        public DateTime BorrowDate { get; set; }

        public int BorrowDays { get; set; }

        public DateTime? ReturnDate { get; set; }
    }
}
