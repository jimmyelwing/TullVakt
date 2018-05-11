using System;

namespace TullVakt
{
    public class Guard
    {

        public static int CalculatePrice(Vehicle vehicle, DateTime time)
        {
            const int tollFree = 0;

            if (IsEnvironmentVehicle(vehicle))
                return tollFree;

            if (IsHolidayOrWeekend(time))
                return PriceOfVehicleOnWeekend(vehicle);
            
            if (IsCar(vehicle))
                return PriceOfCar(vehicle, time);

            if (IsTruck(vehicle))
                return PriceOfTruck(time);

            if (IsMotorcycle(vehicle))
                return PriceOfMotorcycle(vehicle, time);

            throw new NotImplementedException();
        }

        private static int PriceOfVehicleOnWeekend(Vehicle vehicle)
        {
            if (IsCar(vehicle))
                return vehicle.Weight < 1000 ? 1000 : 2000;
            if (IsTruck(vehicle))
                return 2000;
            if (IsMotorcycle(vehicle))
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

        public static bool IsMotorcycle(Vehicle vehicle)
        {
            return vehicle.TypeOf == Vehicle.Type.Motorcycle;
        }
    }
}
