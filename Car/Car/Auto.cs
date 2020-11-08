using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Auto
    {
        private static int tankVolume, gasolineConsumption; //объем бака + расход бензина
        
        public static int getDistanceForGasolin(int tankVolume, int gasolineConsumption)
        {
            return tankVolume / gasolineConsumption;
        }
    }
}
