using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TullVakt
{
    public class TollPrices
    {
        public static int PriceOfVehicleOnWeekend(Vehicle vehicle)
        {
            if (vehicle.IsCar())
                return vehicle.Weight < 1000 ? 1000 : 2000;
            if (vehicle.IsTruck())
                return 2000;
            if (vehicle.IsMotorcycle())
                return vehicle.Weight < 1000 ? 700 : 1400;

            throw new ArgumentNullException();
        }

        public static int PriceOfCar(Vehicle vehicle, DateTime time)
        {
            if (Time.IsEveningOrNight(time))
                return vehicle.Weight < 1000 ? 250 : 500;
            return vehicle.Weight < 1000 ? 500 : 1000;
        }

        public static int PriceOfTruck(DateTime time)
        {
            return Time.IsEveningOrNight(time) ? 1000 : 2000;
        }

        public static int PriceOfMotorcycle(Vehicle vehicle, DateTime time)
        {
            if (Time.IsEveningOrNight(time))
                return vehicle.Weight < 1000 ? 175 : 350;
            return vehicle.Weight < 1000 ? 350 : 700;
        }
    }
}
