using System;
using System.Collections.Generic;

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
                throw new NotImplementedException();
            
            CheckVehicleType(vehicle);
            throw new NotImplementedException();
        }

        public static void CheckVehicleType(Vehicle vehicle)
        {
            if (IsCar(vehicle))
            {

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
            return IsHoliday(time) && IsWeekend(time);
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
