using ClassLibrary1.Application.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services.Models
{
    public class CompanyPepsi : Company, ICompany
    {
        public CompanyPepsi(int _id, string _companyName)
        {
            this.Id = _id;
            this.CompanyName = _companyName;
        }

        public decimal CalculateIRPF(decimal _imp)
        {
            return _imp * 1.25m;
        }
    }
}
