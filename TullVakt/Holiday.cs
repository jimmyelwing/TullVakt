using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TullVakt
{
    public class Holiday
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public Holiday(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public Holiday()
        {
            
        }


        public List <Holiday> SwedishHolidays()
        {
            var dateRightNow = new DateTime();
            dateRightNow = DateTime.Now;
            var yearRightNow = dateRightNow.Year;

            var listOfHolidays = new List<Holiday>
            {
                new Holiday("NewYearsDay", new DateTime(yearRightNow, 01, 01)),
                new Holiday("Epiphany", new DateTime(yearRightNow, 01, 06)),
                new Holiday("International Workers' Day", new DateTime(yearRightNow, 05, 01)),
                new Holiday("National Day of Sweden", new DateTime(yearRightNow, 06, 06)),
                new Holiday("Christmas Day", new DateTime(yearRightNow, 12, 25)),
                new Holiday("Second Day of Christmas", new DateTime(yearRightNow, 12, 26))
            };
            //TODO: Lägg till moveable holidays

            return listOfHolidays;

        }

    }
}
