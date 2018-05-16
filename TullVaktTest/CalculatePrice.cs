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
            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 01);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

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

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 12, 0, 0);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

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

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 9, 0, 0);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

            Assert.AreEqual(1000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfRegularCarWeight900kgAndPassesOnWeekendOrHolidayAt20_PriceIs1000()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 900
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 01, 20, 0, 0);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

            Assert.AreEqual(1000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfRegularCarWeight1000kgAndPassesOnWeekendOrHolidayAt05_PriceIs2000()
        {
            var car = new Vehicle
            {
                TypeOf = Vehicle.Type.Car,
                EnvironmentVehicle = false,
                Weight = 1000
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 01, 05, 00, 00);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

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

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 19, 01, 00);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

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

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 19, 01, 00);
            var price = TollGuard.CalculatePrice(car, timeVehicleIsPassingThrough);

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
            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 12, 00, 00);
            var price = TollGuard.CalculatePrice(truck, timeVehicleIsPassingThrough);

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
            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 03, 00, 00);
            var price = TollGuard.CalculatePrice(truck, timeVehicleIsPassingThrough);

            Assert.AreEqual(1000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfTruckPassesOnHolidayOrWeekendAt12_PriceIs2000()
        {
            var truck = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck,
                Weight = 600
            };
            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 05, 12, 00, 00);
            var price = TollGuard.CalculatePrice(truck, timeVehicleIsPassingThrough);

            Assert.AreEqual(2000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfTruckPassesOnHolidayOrWeekendAt03_PriceIs2000()
        {
            var truck = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck,
                Weight = 2500
            };
            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 05, 03, 00, 00);
            var price = TollGuard.CalculatePrice(truck, timeVehicleIsPassingThrough);

            Assert.AreEqual(2000, price);
        }

        [TestMethod]
        public void CalculatePrice_IfMotorcycle800kgPassesOnWeekdayAt12_PriceIs350()
        {
            var motorcycle = new Vehicle
            {
                TypeOf = Vehicle.Type.Motorcycle,
                Weight = 800
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 12, 00, 00);
            var price = TollGuard.CalculatePrice(motorcycle, timeVehicleIsPassingThrough);

            Assert.AreEqual(350, price);
        }

        [TestMethod]
        public void CalculatePrice_IfMotorcycle800kgPassesOnWeekdayAt20_PriceIs175()
        {
            var motorcycle = new Vehicle
            {
                TypeOf = Vehicle.Type.Motorcycle,
                Weight = 800
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 20, 00, 00);
            var price = TollGuard.CalculatePrice(motorcycle, timeVehicleIsPassingThrough);

            Assert.AreEqual(175, price);
        }

        [TestMethod]
        public void CalculatePrice_IfMotorcycle1200kgPassesOnWeekdayAt12_PriceIs700()
        {
            var motorcycle = new Vehicle
            {
                TypeOf = Vehicle.Type.Motorcycle,
                Weight = 1200
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 12, 00, 00);
            var price = TollGuard.CalculatePrice(motorcycle, timeVehicleIsPassingThrough);

            Assert.AreEqual(700, price);
        }

        [TestMethod]
        public void CalculatePrice_IfMotorcycle1200kgPassesOnWeekdayAt20_PriceIs350()
        {
            var motorcycle = new Vehicle
            {
                TypeOf = Vehicle.Type.Motorcycle,
                Weight = 1200
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 08, 20, 00, 00);
            var price = TollGuard.CalculatePrice(motorcycle, timeVehicleIsPassingThrough);

            Assert.AreEqual(350, price);
        }




        [TestMethod]
        public void CalculatePrice_IfMotorcycle800kgPassesOnWeekendAt20_PriceIs700()
        {
            var motorcycle = new Vehicle
            {
                TypeOf = Vehicle.Type.Motorcycle,
                Weight = 800
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 05, 20, 00, 00);
            var price = TollGuard.CalculatePrice(motorcycle, timeVehicleIsPassingThrough);

            Assert.AreEqual(700, price);
        }

        [TestMethod]
        public void CalculatePrice_IfMotorcycle1200kgPassesOnWeekendOrHolidayAt12_PriceIs1400()
        {
            var motorcycle = new Vehicle
            {
                TypeOf = Vehicle.Type.Motorcycle,
                Weight = 1200
            };

            var timeVehicleIsPassingThrough = new DateTime(2018, 05, 05, 12, 00, 00);
            var price = TollGuard.CalculatePrice(motorcycle, timeVehicleIsPassingThrough);

            Assert.AreEqual(1400, price);
        }
    }
}
