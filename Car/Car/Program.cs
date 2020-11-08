using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car {
    class Program {
        static void Main(string[] args) {
            Console.Write("Введите объем бака (л): ");
            String input = Console.ReadLine();
            int tank = int.Parse(input);
            Console.Write("Введите расход бензина (л на 1 км): ");
            input = Console.ReadLine();
            int gasoline = int.Parse(input);
            Console.Write("Введите длину пути (км): ");
            input = Console.ReadLine();
            int distance = int.Parse(input);

            Car car = new Car(gasoline, tank, distance);

            car.refuelingAmount();
            car.gasolineForRefueling();
            car.distanceForRefueling();
            car.theLastRefueling();
            Console.ReadKey();
        }
    }
}
