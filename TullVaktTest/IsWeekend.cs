using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class IsWeekend
    {
        [TestMethod]
        public void IsWeekend_IfVehiclePassesOnSaturday_ReturnTrue()
        {
            var car = new Vehicle();
            var isWeekend = Time.IsHolidayOrWeekend(new DateTime(2018, 05, 12));
            Assert.IsTrue(isWeekend);
        }

        [TestMethod]
        public void IsWeekend_IfVehiclePassesOnSunday_ReturnTrue()
        {
            var car = new Vehicle();
            var isWeekend = Time.IsHolidayOrWeekend(new DateTime(2016, 08, 07));
            Assert.IsTrue(isWeekend);
        }
    }
}
