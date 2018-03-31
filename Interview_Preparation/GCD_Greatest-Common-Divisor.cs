using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class GCD_Greatest_Common_Divisor
    {
        public static void GenerateGCD(int inputa, int inputb)
        {
            Console.WriteLine(GetGCD(inputa, inputb));

        }

        public static int GetGCD(int inputa, int inputb)
        {
            if(inputb == 0)
                return inputa;

            return GetGCD(inputb, inputa % inputb);
        }
    }
}
