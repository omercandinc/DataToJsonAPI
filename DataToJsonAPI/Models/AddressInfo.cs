using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataToJsonAPI.Models
{
    public class AddressInfo
    {
        public List<City> Cities { get; set; }
    }

    public class City
    {
        public string CityName { get; set; }
        public string CityCode { get; set; }
        public string DistrictName { get; set; }
        public string ZipCode { get; set; }
    }
}