using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TullVakt
{
    public class TollPrices
    {

        private static int PriceOnWeekend(int priceOfVehicle) => priceOfVehicle * 2;
        private static int PriceDuringEvening(int priceOfVehicle) => priceOfVehicle / 2;
        public static int PriceOfCar(Vehicle vehicle, DateTime timeVehicleIsPassingThrough)
        {
            const int carBelow1000Kg = 500;
            const int carAbove1000Kg = carBelow1000Kg * 2;

            if (Time.IsHolidayOrWeekend(timeVehicleIsPassingThrough))
                return vehicle.Weight < 1000 ? PriceOnWeekend(carBelow1000Kg) : PriceOnWeekend(carAbove1000Kg);

            if (Time.IsEveningOrNight(timeVehicleIsPassingThrough))
                return vehicle.Weight < 1000 ? PriceDuringEvening(carBelow1000Kg): PriceDuringEvening(carAbove1000Kg);

            return vehicle.Weight < 1000 ? carBelow1000Kg : carAbove1000Kg;
        }

        public static int PriceOfTruck(DateTime timeVehicleIsPassingThrough)
        {
            if (Time.IsHolidayOrWeekend(timeVehicleIsPassingThrough))
                return 2000;
            return Time.IsEveningOrNight(timeVehicleIsPassingThrough) ? 1000 : 2000;
        }

        public static int PriceOfMotorcycle(Vehicle vehicle, DateTime timeVehicleIsPassingThrough)
        {
            if (Time.IsHolidayOrWeekend(timeVehicleIsPassingThrough))
                return vehicle.Weight < 1000 ? 700 : 1400;

            if (Time.IsEveningOrNight(timeVehicleIsPassingThrough))
                return vehicle.Weight < 1000 ? 175 : 350;

            return vehicle.Weight < 1000 ? 350 : 700;
        }
    }
}
