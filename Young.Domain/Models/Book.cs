using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Young.Domain.Models
{
    public class Book: IAggregateRoot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Guid TestGuid { get; set; }

        public string Author { get; set; }

        public decimal Price { get; set; }

        public DateTime PubDate { get; set; }

        public BorrowStatus Status { get; set; }

        [NotMapped]
        public List<BorrowRecord> BorrowRecords { get; set; }
    }

    public enum BorrowStatus
    {
        UnBorrow = 0,

        Borrowing = 1
    }
}
