using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Bicycle : Vehicle
    {
        private string _marka;
        private Materials _material;
        private KindOfBicycle _kindOfBicycle;

        public string Marka { 
            get => _marka; 
            set => _marka = value.Length > 0 ? value : "Marka"; 
        }

        public Materials Material { 
            get => _material; 
            set => _material = value; 
        }

        internal KindOfBicycle KindOfBicycle { 
            get => _kindOfBicycle; 
            set => _kindOfBicycle = value; 
        }

        public Bicycle(int x, int y, int maxSpeed, int countOfWheels, string nameOfOwner, string marka, Materials material, KindOfBicycle kindOfBicycle) : base(x, y, maxSpeed, countOfWheels, nameOfOwner)
        {
            Marka = marka;
            Material = material;
            KindOfBicycle = kindOfBicycle;
        }

        public override string ToString()
        {
            return $"Велосипед:\nМарка велосипеда = {Marka}\n Материал = {Material}\nВид велосипедаe = {KindOfBicycle} {base.ToString()}";
        }
    }
}
