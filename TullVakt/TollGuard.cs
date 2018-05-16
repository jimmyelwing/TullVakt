using System;

namespace TullVakt
{
    public class TollGuard
    {
        public static int CalculatePrice(Vehicle vehicle, DateTime timeVehicleIsPassingThrough)
        {
            if (vehicle == null)
                throw new ArgumentNullException();

            const int tollFree = 0;
            if (vehicle.IsEnvironmentVehicle())
                return tollFree;

            if (vehicle.IsCar())
                return TollPrices.PriceOfCar(vehicle, timeVehicleIsPassingThrough);

            if (vehicle.IsTruck())
                return TollPrices.PriceOfTruck(timeVehicleIsPassingThrough);

            if (vehicle.IsMotorcycle())
                return TollPrices.PriceOfMotorcycle(vehicle, timeVehicleIsPassingThrough);

            throw new InvalidOperationException();
        }
    }
}
