using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Parking
    {
        private Vehicle[] _vehicles;

        internal Vehicle[] Vehicles => _vehicles;

        public Parking(params Vehicle[] vehicles)
        {
            _vehicles = vehicles;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            Array.Resize(ref _vehicles, _vehicles.Length + 1);
            _vehicles[_vehicles.Length - 1] = vehicle;
        }
    }
}
