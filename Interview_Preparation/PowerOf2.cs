using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class PowerOf2
    {
        public static void GeneratePowerOf2(int power)
        {
            Console.WriteLine("Final answer -> " + FindPowerOf2(2, power));

        }

        public static float FindPowerOf2(float input, int power)
        {
            if (power == 0)
                return 1;

            return input * FindPowerOf2(input, power - 1); 
        }
    }
}
