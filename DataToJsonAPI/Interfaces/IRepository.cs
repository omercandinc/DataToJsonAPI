using DataToJsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataToJsonAPI.Interfaces
{
    public interface IRepository
    {
       AddressInfo getAll();
       AddressInfo get(string name);
       AddressInfo getAllOrderByCity(string name);
    }
}
