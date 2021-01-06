using DataToJsonAPI.Interfaces;
using DataToJsonAPI.Models;
using DataToJsonAPI.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DataToJsonAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        IRepository repository;
        public ValuesController()
        {
            repository = new FactoryService().GetRepository();
        }

        public AddressInfo Get()
        {
            return repository.getAll();
        }

        // GET api/values/5
        public AddressInfo Get(string City)
        {
            return repository.get(City);
        }
        public AddressInfo GetAllOrderByCity(string City)
        {
            return repository.get(City);
        }




    }
}
