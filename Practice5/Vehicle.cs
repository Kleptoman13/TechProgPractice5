using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Vehicle
    {
        private VehicleInfo _vehicleInfo;

        public Vehicle(int x, int y, int maxSpeed, int countOfWheels, string nameOfOwner)
        {
            _vehicleInfo = new VehicleInfo(x, y, maxSpeed, countOfWheels, nameOfOwner);
        }

        public override string ToString()
        {
            return $"{_vehicleInfo}";
        }
    }
}
