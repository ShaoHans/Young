using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Domain.Models
{
    public class Reader : IAggregateRoot
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Address Local { get; set; }

        public Address Nation { get; set; }

        public List<BorrowRecord> BorrowRecords { get; set; }
    }
}
