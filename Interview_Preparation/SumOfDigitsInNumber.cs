using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class SumOfDigitsInNumber
    {
        public static void GenerateSumOfDigitsInNumber(int input)
        {
            Console.WriteLine("Final answer -> " + ComputeSumOfDigitsInNumber(input));

        }

        public static int ComputeSumOfDigitsInNumber(int input)
        {
            if (input / 10 == 0)
                return input;

            return ComputeSumOfDigitsInNumber(input / 10) + input % 10; 
        }
    }
}
