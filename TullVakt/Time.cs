using System;

namespace TullVakt
{
    public class Time
    {
        public static bool IsEveningOrNight(DateTime time)
        {
            var startOfEvening = new TimeSpan(19, 0, 0);
            var endOfNight = new TimeSpan(06, 0, 0);

            if (time.TimeOfDay >= startOfEvening)
                return true;
            if (time.TimeOfDay <= endOfNight)
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
