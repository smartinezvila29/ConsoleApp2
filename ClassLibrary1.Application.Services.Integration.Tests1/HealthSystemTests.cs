using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Application.Services.Integration.Tests
{
    [TestClass()]
    public class HealthSystemTests
    {
        private HealthSystem _healthSystem;

        [TestInitialize]
        public void Setup()
        {
            _healthSystem = new HealthSystem();
        }

        [TestMethod()]
        [DataRow("CocaCola", true)]
        [DataRow("CocaCola", true)]
        [DataRow("Pepsi", true)]
        [DataRow("Pepsi", true)]
        public void AddCompanyCocaTest_Result_Ok(string companyName, bool expectedResult)
        {
            var result = _healthSystem.AddCompanyCoca(companyName);
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod()]
        [DataRow("CocaCola", false)]
        public void AddCompanyCocaTest_Result_False(string companyName, bool expectedResult)
        {
            _healthSystem.AddCompanyCoca(companyName);
            var result = _healthSystem.AddCompanyCoca(companyName);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod()]
        public void AddCompanyPepsiTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetCompanyTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AutoIncrementIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddDeviceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetDeviceTest()
        {
            Assert.Fail();
        }
    }
}