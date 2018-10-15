using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Domain.Models
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
