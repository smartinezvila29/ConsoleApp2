using ClassLibrary1.Application.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services.Contracts
{
    public interface IHealthSystem
    {
        bool AddCompanyCoca(string companyName);
        bool AddCompanyPepsi(string companyName);
        Company GetCompany(string companyName);
    }
}
