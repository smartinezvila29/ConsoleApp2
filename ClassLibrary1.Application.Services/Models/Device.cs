using ClassLibrary1.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services.Models
{
    public class Device : IDevice
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public List<IMetric> Metrics { get; set;}
        public Company Company { get; set; }

        public Device(int id, string name, string code, Company company)
        {
            Id = id;
            Name = name;
            Code = code;
            Company = company;
        }
    }
}
