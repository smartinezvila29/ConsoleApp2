using ClassLibrary1.Application.Services.Contracts;
using ClassLibrary1.Application.Services.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services
{
    public class HealthSystem : IHealthSystem
    {
        public List<Company> CompanyList = new List<Company>();
        public List<Device> DeviceList = new List<Device>();

        public HealthSystem()
        {
        }

        public bool AddCompanyCoca(string companyName)
        {
            try
            {
                int id = AutoIncrementId();
                if (GetCompany(companyName) != null)
                { throw new Exception("Ya existe la empresa"); }
                CompanyCoca companyCoca = new CompanyCoca(id, companyName);
                CompanyList.Add(companyCoca);
                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool AddCompanyPepsi(string companyName)
        {
            try
            {
                int id = AutoIncrementId();
                if (GetCompany(companyName) != null)
                { throw new Exception("Ya existe la empresa"); }
                CompanyPepsi companyPepsi = new CompanyPepsi(id, companyName);
                CompanyList.Add(companyPepsi);
                return true;
            }catch(Exception ex) {
                return false;
            }
        }

        public Company GetCompany(string companyName)
        {
            return CompanyList.Where(x => x.CompanyName.Equals(companyName)).FirstOrDefault();
            //Company _company = null;
            //foreach(var  company in CompanyList)
            //{
            //    if(company.CompanyName.Equals(companyName))
            //        _company = company; 
            //}
            //return _company;
        }

        public int AutoIncrementId()
        {
            int id = 1;
            if (CompanyList.Count > 0) { id = CompanyList.Count + 1; }
            return id;
        }

        public bool AddDevice(string deviceName, string code, Company company)
        {
            if(GetDevice(code)!=null) { throw new Exception("Ya existe el dispositivo"); }
            int id = 1;
            if (DeviceList.Count > 0) { id = DeviceList.Count + 1; }
            Device device = new Device(id, deviceName, code, company);
            return true;
        }

        public IDevice GetDevice(string deviceCode) 
        {
            Device device = null;
            foreach(var item in DeviceList)
            {
                if (item.Code.Equals(deviceCode)) { device = item; }
            }
            return device;
        }
    }
}

