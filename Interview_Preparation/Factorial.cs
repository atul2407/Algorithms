using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class Factorial
    {
        public static void GenerateFactorial(int input)
        {
            Console.WriteLine(FindFactorial(input));

        }

        public static int FindFactorial(int input)
        {
            if (input < 0)
                return -1;
            else if (input == 0)
                return 1;

            return input * (FindFactorial(input - 1));
        }
    }
}
