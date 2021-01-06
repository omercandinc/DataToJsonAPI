using DataToJsonAPI.Interfaces;
using DataToJsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace DataToJsonAPI.Services
{
    public class FactoryService
    {
        public readonly string configValue = ConfigurationManager.AppSettings["DataType"];
        public DataType dataType;

        public FactoryService()
        {
            dataType = (DataType)Enum.Parse(typeof(DataType), configValue);
        }

        public IRepository GetRepository()
        {
            switch (dataType)
            {
                case DataType.XML:
                    return new XmlRepository();
                case DataType.CSV:
                    return new CSVRepository();
                default:
                    throw new NotSupportedException("Desteklenmeyen veri türü");
            }

        }
    }
}