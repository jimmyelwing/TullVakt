using System;
using System.Collections.Generic;

namespace TullVakt
{
    public class Guard
    {
        public static void VehiclePassesThrough(Vehicle vehicle, DateTime time)
        {
            
        }

        public static bool CheckIfHoliday(DateTime time)
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


        public static bool CheckIfWeekend(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday || 
                   dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
