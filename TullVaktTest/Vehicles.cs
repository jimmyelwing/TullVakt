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
    public class Vehicles
    {
        [TestMethod]
        public void IsCar_IfVehicleIsACar_ReturnTrue()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Car
            };

            var isCar = Guard.IsCar(vehicle);

            Assert.IsTrue(isCar);
        }

        [TestMethod]
        public void IsCar_IfVehicleIsATruck_ReturnFalse()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck
            };

            var isCar = Guard.IsCar(vehicle);

            Assert.IsFalse(isCar);
        }

        [TestMethod]
        public void IsTruck_IfVehicleIsATruck_ReturnTrue()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck
            };

            var isTruck = Guard.IsTruck(vehicle);

            Assert.IsTrue(isTruck);
        }

        [TestMethod]
        public void IsTruck_IfVehicleIsACar_ReturnFalse()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Car
            };

            var isTruck = Guard.IsTruck(vehicle);

            Assert.IsFalse(isTruck);
        }

        [TestMethod]
        public void IsMotorcycle_IfVehicleIsAMotorcycle_ReturnTrue()
        {
            var vehicle = new Vehicle
            {
                TypeOf=Vehicle.Type.Motorcycle
            };
            var isMotorcycle = Guard.IsMotorcycle(vehicle);

            Assert.IsTrue(isMotorcycle);
        }

        [TestMethod]
        public void IsMotorcycle_IfVehicleIsACar_ReturnFalse()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Car
            };

            var isMotorcycle = Guard.IsMotorcycle(vehicle);

            Assert.IsFalse(isMotorcycle);
        }

    }
}
