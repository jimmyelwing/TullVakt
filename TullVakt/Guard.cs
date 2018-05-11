using System;

namespace TullVakt
{
    public class Guard
    {

        public static void VehiclePassesThrough()
        {

        }

        public static int CalculatePrice(Vehicle vehicle, DateTime time)
        {
            if (IsEnvironmentVehicle(vehicle))
                return 0;

            if (IsHolidayOrWeekend(time))
                if (IsCar(vehicle))
                    return vehicle.Weight < 1000 ? 1000 : 2000;

            if (IsCar(vehicle))
            {
                if (IsEveningOrNight(time))
                    return vehicle.Weight < 1000 ? 250 : 500;
                return vehicle.Weight < 1000 ? 500 : 1000;
            }

            if (IsTruck(vehicle))
            {
                return IsEveningOrNight(time) ? 1000 : 2000;
            }

            throw new NotImplementedException();
        }

        public static bool IsEveningOrNight(DateTime time)
        {
            var start = new TimeSpan(19,0,0);
            var end = new TimeSpan(06, 0, 0);

            if (time.TimeOfDay >= start)
                return true;
            if (time.TimeOfDay <= end)
                return true;
            return false;
        }

        public static string CheckVehicleType(Vehicle vehicle)
        {
            if (IsCar(vehicle))
                return "car";
            else
            {
                throw new NotImplementedException();
            }
        }


        public static bool IsEnvironmentVehicle(Vehicle vehicle)
        {
            return vehicle.EnvironmentVehicle;
        }

        public static bool IsCar(Vehicle vehicle)
        {
            return vehicle.TypeOf == Vehicle.Type.Car;
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

        public static bool IsTruck(Vehicle vehicle)
        {
            return vehicle.TypeOf == Vehicle.Type.Truck;
        }
    }
}
