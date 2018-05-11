namespace TullVakt
{

    public class Vehicle
    {
        public Type TypeOf { get; set; }
        public enum Type
        {
            Car,
            Truck
        }
        public bool EnvironmentVehicle { get; set; }

        public int Weight { get; set; }

        public Vehicle()
        {

        }
    }

}
