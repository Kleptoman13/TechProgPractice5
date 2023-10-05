using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Car : Vehicle
    {
        private string _marka;
        private int _horsepower;
        private int _carMileage;

        public int CarMileage { 
            get => _carMileage;
            set => _carMileage = value >= 0 ? value : 0;
        }

        public int Horsepower { 
            get => _horsepower; 
            set => _horsepower = value > 0 ? value : 1; 
        }

        public string Marka { 
            get => _marka; 
            set => _marka = value.Length > 0 ? value : "Marka"; 
        }

        public Car(int x, int y, int maxSpeed, int countOfWheels, string nameOfOwner, string marka, int horsepower, int carMileage) : base(x, y, maxSpeed, countOfWheels, nameOfOwner)
        {
            Marka = marka;
            Horsepower = horsepower;
            CarMileage = carMileage;
        }


        public override string ToString()
        {
            return $"Автомобиль:\nМарка машины = {Marka}\nHorsepower = {Horsepower}\nПробег = {CarMileage} {base.ToString()}";
        }
    }
}
