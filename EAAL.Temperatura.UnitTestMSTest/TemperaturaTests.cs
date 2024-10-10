using Microsoft.VisualStudio.TestTools.UnitTesting;
using EAAL.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAL.Temperatura.Tests
{
    [TestClass()]
    public class TemperaturaTests
    {
        [TestMethod()]
        public void CelsiusToFahrenheitTest()
        {
            Temperatura temp = new Temperatura();

            double result = temp.CelsiusToFahrenheit(35, 95);

            Assert.AreEqual(95, result);
        }

        [TestMethod()]
        public void FahrenheitToCelsiusTest()
        {
            Temperatura temp = new Temperatura();

            double result = temp.FahrenheitToCelsius(95, 35);

            Assert.AreEqual(35, result);
        }
    }
}