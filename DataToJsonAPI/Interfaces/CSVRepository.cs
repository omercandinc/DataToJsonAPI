using DataToJsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;



namespace DataToJsonAPI.Interfaces
{
    public class CSVRepository : IRepository
    {
        public readonly string path = ConfigurationManager.AppSettings["Path"];

        public AddressInfo get(string name)
        {
            var result= getAll().Cities.Where(c=>c.CityName==name);
            AddressInfo addressInfo = new AddressInfo();
            addressInfo.Cities = result.ToList();
            return addressInfo;
        }

        public AddressInfo getAll()
        {

            var csv = new List<City>(); // or, List<YourClass>
            var lines = System.IO.File.ReadAllLines(@path);
            for (int i=1; i<lines.Length; i++)
            {
                string[] lineStr= lines[i].Split(',');
                City ct = new City();
                ct.CityName = lineStr[0];
                ct.CityCode = lineStr[1];
                ct.DistrictName = lineStr[2];
                ct.ZipCode = lineStr[3];
                csv.Add(ct); // or, populate YourClass      
            }
            AddressInfo addressInfo = new AddressInfo();
            addressInfo.Cities = csv;
            return addressInfo;
        }

        public AddressInfo getAllOrderByCity(string name)
        {
            var result = getAll().Cities.Where(c => c.CityName == name).OrderByDescending(c => c.CityName);
            AddressInfo addressInfo = new AddressInfo();
            addressInfo.Cities = result.ToList();
            return addressInfo;
        }
    }
}