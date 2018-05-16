using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class IsHoliday
    {


        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnInternationalWorkersDay_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Time.IsHolidayOrWeekend(new DateTime(2015,05,01));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnNewYearsEve_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Time.IsHolidayOrWeekend(new DateTime(2011, 01, 01));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnEpiphany_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Time.IsHolidayOrWeekend(new DateTime(2018, 01, 06));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnSwedishNationalDay_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Time.IsHolidayOrWeekend(new DateTime(2001, 06, 06));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnChristmasDay_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Time.IsHolidayOrWeekend(new DateTime(1988, 12, 25));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnSecondDayOfChristmas_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Time.IsHolidayOrWeekend(new DateTime(2007, 12, 26));
            Assert.IsTrue(isHoliday);
        }

    }
}
