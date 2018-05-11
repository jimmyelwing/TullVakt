using System;
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
            var car = new Vehicle { EnvironmentVehicle = true };
            var time = new DateTime(2018, 05, 01);
            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void CalculatePrice_RegularCarWeight900kgAndPassesOnWeekdayAt12_PriceIs500()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 900
            };

            var time = new DateTime(2018, 05, 08, 12, 0, 0);
            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(500, price);
        }

        [TestMethod]
        public void CalculatePrice_IfRegularCarWeight1000kgAndPassesOnWeekdayAt09_PriceIs1000()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 1000
            };

            var time = new DateTime(2018, 05, 08, 9, 0, 0);
            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(1000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfRegularCarWeight900kgAndPassesOnWeekendOrHoliday_PriceIs1000()
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
        public void CalculatePrice_IfRegularCarWeight1000kgAndPassesOnWeekendOrHoliday_PriceIs2000()
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

        [TestMethod]
        public void CalculatePrice_IfRegularCarWeight1000kgAndPassesOnWeekdayAt19_PriceIs500()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 1000
            };

            var time = new DateTime(2018, 05, 08, 19, 01, 00);
            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(500, price);
        }

        [TestMethod]
        public void CalculatePrice_IfRegularCarWeight900kgAndPassesOnWeekdayAt19_PriceIs250()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 900
            };

            var time = new DateTime(2018, 05, 08, 19, 01, 00);
            var price = Guard.CalculatePrice(car, time);

            Assert.AreEqual(250, price);
        }

        [TestMethod]
        public void CalculatePrice_IfTruckPassesOnWeekdayAt12_PriceIs2000()
        {
            var truck = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck,
                Weight = 600
            };
            var time = new DateTime(2018, 05, 08, 12, 00, 00);
            var price = Guard.CalculatePrice(truck, time);

            Assert.AreEqual(2000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfTruckPassesOnWeekdayAt03_PriceIs1000()
        {
            var truck = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck,
                Weight = 2500
            };
            var time = new DateTime(2018, 05, 08, 03, 00, 00);
            var price = Guard.CalculatePrice(truck, time);

            Assert.AreEqual(1000, price);
        }
    }
}
