using System;

namespace TullVakt
{
    public class Guard
    {

        public static int CalculatePrice(Vehicle vehicle, DateTime timeVehicleIsPassingThrough)
        {
            const int tollFree = 0;

            if (vehicle.IsEnvironmentVehicle())
                return tollFree;

            if (IsHolidayOrWeekend(timeVehicleIsPassingThrough))
                return PriceOfVehicleOnWeekend(vehicle);
            
            if (vehicle.IsCar())
                return PriceOfCar(vehicle, timeVehicleIsPassingThrough);

            if (vehicle.IsTruck())
                return PriceOfTruck(timeVehicleIsPassingThrough);

            if (vehicle.IsMotorcycle())
                return PriceOfMotorcycle(vehicle, timeVehicleIsPassingThrough);

            throw new NotImplementedException();
        }

        private static int PriceOfVehicleOnWeekend(Vehicle vehicle)
        {
            if (vehicle.IsCar())
                return vehicle.Weight < 1000 ? 1000 : 2000;
            if (vehicle.IsTruck())
                return 2000;
            if (vehicle.IsMotorcycle())
                return vehicle.Weight < 1000 ? 700 : 1400;

            throw new ArgumentNullException();
        }

        private static int PriceOfCar(Vehicle vehicle, DateTime time)
        {
            if (IsEveningOrNight(time))
                return vehicle.Weight < 1000 ? 250 : 500;
            return vehicle.Weight < 1000 ? 500 : 1000;
        }

        private static int PriceOfTruck(DateTime time)
        {
            return IsEveningOrNight(time) ? 1000 : 2000;
        }

        private static int PriceOfMotorcycle(Vehicle vehicle, DateTime time)
        {
            if (IsEveningOrNight(time))
                return vehicle.Weight < 1000 ? 175 : 350;
            return vehicle.Weight < 1000 ? 350 : 700;
        }

        public static bool IsEveningOrNight(DateTime time)
        {
            var start = new TimeSpan(19, 0, 0);
            var end = new TimeSpan(06, 0, 0);

            if (time.TimeOfDay >= start)
                return true;
            if (time.TimeOfDay <= end)
                return true;
            return false;
        }

        public static bool IsHolidayOrWeekend(DateTime time)
        {
            return IsHoliday(time) || IsWeekend(time);
        }

        public static bool IsHoliday(DateTime time)
        {
            var swedishHolidays = new Holiday().SwedishHolidays();
            foreach (var holiday in swedishHolidays)
            {
                if (holiday.Date.Month == time.Month
                    && holiday.Date.Day == time.Day)
                    return true;
            }
            return false;
        }
        
        public static bool IsWeekend(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday ||
                   dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
