using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TullVakt
{

    public class Vehicle
    {
        public Type TypeOf { get; set; }
        public enum Type
        {
            Car,
        }
        public bool EnvironmentVehicle { get; set; }

        public int Weight { get; set; }

        public Vehicle()
        {

        }
    }

}
