using System;
using System.Collections.Generic;
using System.Text;

namespace Young.Domain.Models
{
    public class Address
    {
        public int ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public int CityCode { get; set; }

        public string CityName { get; set; }
    }
}
