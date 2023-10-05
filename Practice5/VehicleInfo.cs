using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class VehicleInfo
    {
        private int x;
        private int y;
        private int _maxSpeed;
        private int _countOfWheels;
        private string _nameOfOwner;

        public int X { 

            get => x;
            set => x = value > 0 ? value : 0;
        }
        public int Y { 

            get => y;
            set => y = value > 0 ? value : 0;
        }
        public int MaxSpeed { 

            get => _maxSpeed; 
            set => _maxSpeed = value > 0 ? value : 0;
        }
        public int CountOfWheels { 
            get => _countOfWheels; 
            set => _countOfWheels = value > 0 ? value : 2; 
        }
        public string NameOfOwner { 

            get => _nameOfOwner;
            set => _nameOfOwner = value.Length > 0 ? value : "Owner";
        }

        public VehicleInfo(int x, int y, int maxSpeed, int countOfWheels, string nameOfOwner)
        {
            X = x;
            Y = y;
            MaxSpeed = maxSpeed;
            CountOfWheels = countOfWheels;
            NameOfOwner = nameOfOwner;
        }

        public override string ToString()
        {
            return $"\nМестоположеник=({X}, {Y})\nМаксимальная скорость = {MaxSpeed}\nКоличество колес = {CountOfWheels}\nИмя владельца = {NameOfOwner}\n";
        }
    }
}
