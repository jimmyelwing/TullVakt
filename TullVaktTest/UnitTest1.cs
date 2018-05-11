using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void VehicleIsCarAndWeight600_PassedOnARegularWeekday_StandardPriceIs500SEK()
        //{
        //    var car = new Vehicle { TypeOf = Vehicle.Type.Car, Weight = 600 };

        //    Guard.VehiclePassesThrough(car, new DateTime(2018, 05, 08));

        //    Assert.AreEqual();
        //}

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnInternationalWorkersDay_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Guard.CheckIfHoliday(new DateTime(2015,05,01));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnNewYearsEve_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Guard.CheckIfHoliday(new DateTime(2011, 01, 01));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnEpiphany_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Guard.CheckIfHoliday(new DateTime(2018, 01, 06));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnSwedishNationalDay_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Guard.CheckIfHoliday(new DateTime(2001, 06, 06));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnChristmasDay_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Guard.CheckIfHoliday(new DateTime(1988, 12, 25));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsHoliday_IfVehiclePassesOnSecondDayOfChristmas_ReturnTrue()
        {
            var car = new Vehicle();
            var isHoliday = Guard.CheckIfHoliday(new DateTime(2007, 12, 26));
            Assert.IsTrue(isHoliday);
        }

        [TestMethod]
        public void IsWeekend_IfVehiclePassesOnASaturday_ReturnTrue()
        {
            var car = new Vehicle();
            var isWeekend = Guard.CheckIfWeekend(new DateTime(2018, 05, 12));
            Assert.IsTrue(isWeekend);
        }

        [TestMethod]
        public void IsWeekend_IfVehiclePassesOnASunday_ReturnTrue()
        {
            var car = new Vehicle();
            var isWeekend = Guard.CheckIfWeekend(new DateTime(2016, 08, 07));
            Assert.IsTrue(isWeekend);
        }
    }


}
