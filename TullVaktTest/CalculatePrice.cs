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

        [TestMethod]
        public void CalculatePrice_IfVehicleIsRegularCarWeight900kgAndPassesOnWeekday_PriceIs500()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 900
            };

            var time = new DateTime(2018, 05, 08);

            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(500, price);

        }

        [TestMethod]
        public void CalculatePrice_IfVehicleIsRegularCarWeight1000kgAndPassesOnWeekday_PriceIs1000()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 1000
            };

            var time = new DateTime(2018, 05, 08);

            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(1000, price);

        }

        [TestMethod]
        public void CalculatePrice_IfVehicleIsRegularCarWeight900kgAndPassesOnWeekendOrHoliday_PriceIs1000()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 900
            };

            var time = new DateTime(2018, 05, 01);

            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(1000, price);

        }

        [TestMethod]
        public void CalculatePrice_IfVehicleIsRegularCarWeight1000kgAndPassesOnWeekendOrHoliday_PriceIs2000()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 1000
            };

            var time = new DateTime(2018, 05, 01);

            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(2000, price);

        }
    }
}
