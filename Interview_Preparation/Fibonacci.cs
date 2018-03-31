using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class Fibonacci
    {
        public static void GenerateFibonacci(int input)
        {
            Console.WriteLine(FindFibonacci(input));

        }

        public static int FindFibonacci(int input)
        {
            if (input <= 0)
                return 0;
            else if (input == 1)
                return 1;

            return FindFibonacci(input - 1) + FindFibonacci(input - 2);
        }
    }
}
