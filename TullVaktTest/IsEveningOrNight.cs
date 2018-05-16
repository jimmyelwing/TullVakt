using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class IsEveningOrNight
    {

        [TestMethod]
        public void IsEveningOrNight_IfTimeIsAfter19_ReturnTrue()
        {
            var timeVehicleIsPassingThrough= new DateTime(2018, 02, 05, 20, 0, 0);
            var isEvening = Time.IsEveningOrNight(timeVehicleIsPassingThrough);
            Assert.IsTrue(isEvening);
        }

        [TestMethod]
        public void IsEveningOrNight_IfTimeIsBefore06_ReturnTrue()
        {
            var timeVehicleIsPassingThrough= new DateTime(2018, 02, 05, 05, 0, 0);
            var isEvening = Time.IsEveningOrNight((timeVehicleIsPassingThrough));
            Assert.IsTrue(isEvening);
        }

        [TestMethod]
        public void IsEveningOrNight_IfTimeIsAfter06_ReturnFalse()
        {
            var timeVehicleIsPassingThrough= new DateTime(2018, 02, 05, 08, 0, 0);
            var isEvening = Time.IsEveningOrNight(timeVehicleIsPassingThrough);
            Assert.IsFalse(isEvening);
        }

        [TestMethod]
        public void IsEveningOrNight_IfTimeIsBefore19_ReturnFalse()
        {
            var timeVehicleIsPassingThrough= new DateTime(2018, 02, 05, 18, 30, 0);
            var isEvening = Time.IsEveningOrNight(timeVehicleIsPassingThrough);
            Assert.IsFalse(isEvening);
        }
    }
}
