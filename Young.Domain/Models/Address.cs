using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Domain.Models
{
    public class Address
    {
        public int ProvinceId { get; set; }

        public string ProvinceName { get; set; }

        public int CityId { get; set; }

        public string CityName { get; set; }
    }
}
