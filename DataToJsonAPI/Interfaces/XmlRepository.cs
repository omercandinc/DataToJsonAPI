using DataToJsonAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace DataToJsonAPI.Interfaces
{
    public class XmlRepository : IRepository
    {
        public AddressInfo get(string name)
        {
            throw new NotImplementedException();
        }

        public AddressInfo getAll()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressInfo));
            using (TextReader reader = new StringReader(File.ReadAllText("")))
            {
                return (AddressInfo)serializer.Deserialize(reader);
            }
        }

        public AddressInfo getAllOrderByCity(string name)
        {
            throw new NotImplementedException();
        }
    }
}


