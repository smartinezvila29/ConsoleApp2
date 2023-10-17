using ClassLibrary1.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services.Models
{
    public abstract class Company
    {
        public int Id;
        public string CompanyName;

        public decimal CalculateIRPF(decimal _imp)
        {
            throw new NotImplementedException();
        }
    }
}
