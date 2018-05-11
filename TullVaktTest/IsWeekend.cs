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
    public class IsWeekend
    {
        [TestMethod]
        public void IsWeekend_IfVehiclePassesOnSaturday_ReturnTrue()
        {
            var car = new Vehicle();
            var isWeekend = Guard.IsWeekend(new DateTime(2018, 05, 12));
            Assert.IsTrue(isWeekend);
        }

        [TestMethod]
        public void IsWeekend_IfVehiclePassesOnSunday_ReturnTrue()
        {
            var car = new Vehicle();
            var isWeekend = Guard.IsWeekend(new DateTime(2016, 08, 07));
            Assert.IsTrue(isWeekend);
        }
    }
}
