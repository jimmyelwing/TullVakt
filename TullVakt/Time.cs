using System;

namespace TullVakt
{
    public class Time
    {
        public static bool IsEveningOrNight(DateTime timeVehicleIsPassingThrough)
        {
            var startOfEvening = new TimeSpan(19, 0, 0);
            var endOfNight = new TimeSpan(06, 0, 0);

            if (timeVehicleIsPassingThrough.TimeOfDay >= startOfEvening)
                return true;
            if (timeVehicleIsPassingThrough.TimeOfDay <= endOfNight)
                return true;

            return false;
        }

        public static bool IsHolidayOrWeekend(DateTime timeVehicleIsPassingThrough)
        {
            return IsHoliday(timeVehicleIsPassingThrough) || IsWeekend(timeVehicleIsPassingThrough);
        }

        private static bool IsHoliday(DateTime timeVehicleIsPassingThrough)
        {
            var swedishHolidays = new Holiday().SwedishHolidays();
            foreach (var holiday in swedishHolidays)
            {
                if (holiday.Date.Month == timeVehicleIsPassingThrough.Month
                    && holiday.Date.Day == timeVehicleIsPassingThrough.Day)
                    return true;
            }

            return false;
        }

        private static bool IsWeekend(DateTime dateTime)
        {
            return dateTime.DayOfWeek == DayOfWeek.Saturday ||
                   dateTime.DayOfWeek == DayOfWeek.Sunday;
        }
    }
}
