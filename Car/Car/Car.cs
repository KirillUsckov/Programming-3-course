using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car : Auto
    {
        private static int tankVolume, gasolineConsumption, distance, gasolineForDistance, refueling, distanceForRef;
       
        public Car(int gasolineCon, int tankVol, int distanceForDrive)
        {
            tankVolume = tankVol;
            gasolineConsumption = gasolineCon;
            distance = distanceForDrive;
        }

        public static void refuelingAmount()
        {
            gasolineForDistance = distance * gasolineConsumption;//сколько литров для всего пути 120
            refueling = gasolineForDistance / tankVolume - 1;//сколько дозаправок надо сделать
            //Console.WriteLine(gasolineForDistance % tankVolume);
            Console.Write("Требуется " + refueling + " дозаправок.\n");
        }

        public static void gasolineForRefueling()
        {
            Console.Write((refueling * tankVolume) + " литров надо дозаправить.\n");
        }

        public static void distanceForRefueling()
        {
            Console.WriteLine("Дозаправки будут на:");
            int newRefueling = refueling + 1; //сколько полных баков надо на весь путь
            distanceForRef = distance / newRefueling; // сколько км можно проехать на 1 бак
            int newDistance = distance - (distance / newRefueling); //дистанция - 1 полный бак
            for (int i = 1; distanceForRef < newDistance; i++)
            {
                distanceForRef = distance / newRefueling * i;
                Console.WriteLine(distanceForRef + " km.");
            }
        }
        public static void theLastRefueling()
        {
            int gasolineVal = (distance - distanceForRef) * gasolineConsumption; // сколько на весь путь
            Console.WriteLine("Последняя дозаправка на " + gasolineVal + " л.");
        }

    }
}
