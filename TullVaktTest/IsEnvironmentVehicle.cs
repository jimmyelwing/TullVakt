using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class IsEnvironmentVehicle
    {

        [TestMethod]
        public void IsEnvironmentVehicle_IfVehicleIsEnvironmentVehicle_ReturnTrue()
        {
            var car = new Vehicle();
            car.EnvironmentVehicle = true;
            Assert.IsTrue(car.IsEnvironmentVehicle());
        }

        [TestMethod]
        public void IsEnvironmentVehicle_IfVehicleIsNotEnvironmentVehicle_ReturnFalse()
        {
            var car = new Vehicle();
            car.EnvironmentVehicle = false;
            Assert.IsFalse(car.IsEnvironmentVehicle());
        }

    }
}
