using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(140, 30, 280, 4, "Heisenberg1", "Mercedes", 300, 30000);
            Car car2 = new Car(56, 107, 100, 3, "Heisenberg2", "Tuk tuk", 30, 150000);
            Bicycle bicycle1 = new Bicycle(4, 79, 40, 2, "Vanya1", "Salut1", Materials.ALUMINUM, KindOfBicycle.NON_ELECTRICE);
            Bicycle bicycle2 = new Bicycle(4564, 45, 60, 2, "Vanya2", "Salut2", Materials.CARBON, KindOfBicycle.ELECTRIC);
            Cart cart1 = new Cart(34, 456, 15, 4, "Mihalych1", WhoCanPull.HORSE, "Kachan kapusty", 240);
            Cart cart2 = new Cart(45, 3456, 10, 2, "Mihalych2", WhoCanPull.DONKEY, "Bolyshoy kachan kapusty", 100);

            Parking parking = new Parking(car1, car2, bicycle1, bicycle2, cart1, cart2);

            foreach (var item in parking.Vehicles)
            {
                if (item != null) {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
