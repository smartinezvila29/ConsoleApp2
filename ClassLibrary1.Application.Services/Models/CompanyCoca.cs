using ClassLibrary1.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services.Models
{
    public class CompanyCoca : Company, ICompany
    {
        public CompanyCoca(int _id, string _companyName)
        {
            this.Id = _id;
            this.CompanyName = _companyName;
        }

        public decimal CalculateIRPF(decimal _imp)
        {
            return _imp * _imp;
        }
    }
}
