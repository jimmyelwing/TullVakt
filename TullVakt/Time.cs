using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TullVakt
{
    public class Time
    {
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
