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

            Assert.IsTrue(vehicle.IsCar());
        }

        [TestMethod]
        public void IsCar_IfVehicleIsATruck_ReturnFalse()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck
            };

            Assert.IsFalse(vehicle.IsCar());
        }

        [TestMethod]
        public void IsTruck_IfVehicleIsATruck_ReturnTrue()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Truck
            };

            Assert.IsTrue(vehicle.IsTruck());
        }

        [TestMethod]
        public void IsTruck_IfVehicleIsACar_ReturnFalse()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Car
            };
            
            Assert.IsFalse(vehicle.IsTruck());
        }

        [TestMethod]
        public void IsMotorcycle_IfVehicleIsAMotorcycle_ReturnTrue()
        {
            var vehicle = new Vehicle
            {
                TypeOf=Vehicle.Type.Motorcycle
            };

            Assert.IsTrue(vehicle.IsMotorcycle());
        }

        [TestMethod]
        public void IsMotorcycle_IfVehicleIsACar_ReturnFalse()
        {
            var vehicle = new Vehicle
            {
                TypeOf = Vehicle.Type.Car
            };
            
            Assert.IsFalse(vehicle.IsMotorcycle());
        }

    }
}
