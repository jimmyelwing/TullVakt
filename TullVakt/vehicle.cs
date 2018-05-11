namespace TullVakt
{

    public class Vehicle
    {
        public Type TypeOf { get; set; }
        public enum Type
        {
            Car,
            Truck,
            Motorcycle
        }
        public bool EnvironmentVehicle { get; set; }

        public int Weight { get; set; }

        public Vehicle()
        {

        }

        public bool IsCar() => TypeOf == Vehicle.Type.Car;

        public bool IsTruck() => TypeOf == Vehicle.Type.Truck;
       
        public bool IsMotorcycle() => TypeOf == Vehicle.Type.Motorcycle;

        public bool IsEnvironmentVehicle() => EnvironmentVehicle;
    }

}
