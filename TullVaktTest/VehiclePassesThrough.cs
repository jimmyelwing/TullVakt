using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TullVakt;

namespace TullVaktTest
{
    [TestClass]
    public class VehiclePassesThrough
    {
        [TestMethod]
        public void VehicleIsRegularCarAndWeight600_PassedOnARegularWeekday_StandardPriceIs500SEK()
        {
            var car = new Vehicle { TypeOf = Vehicle.Type.Car, Weight = 600 };

            Guard.CalculatePrice(car, new DateTime(2018, 05, 08));

        }
    }
}
