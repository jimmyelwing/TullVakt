using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class CalculatePrice
    {
        [TestMethod]
        public void CalculatePrice_IfVehicleIsEnvironmental_PriceIs0()
        {
            var car = new Vehicle {EnvironmentVehicle = true};
            var time = new DateTime(2018,05,01);
            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(0, price);
        }
    }
}
