using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class PrimeNumber
    {
        public static void IsPrimeNumber(int[] input)
        {
            for (int j = 0; j < input.Length; j++)
            {
                bool isPrime = false;
                //for (int i = 2; i <= input[j]/2; i++)
                //{
                //    if (input[j] != i && input[j] % i == 0)
                //    {
                //        Console.WriteLine(input[j] + " is not prime number.");
                //        isPrime = true;
                //        break;
                //    }
                //}

                //It should only go upto square root of n because if n is divisible by a number greater than its square root then it's divisible by something smaller than it. 
                for (int i = 2; i <= Math.Sqrt(input[j]); i++)
                {
                    if (input[j] % i == 0)
                    {
                        Console.WriteLine(input[j] + " is not prime number.");
                        isPrime = true;
                        break;                        
                    }
                }
                    if (!isPrime)
                        Console.WriteLine(input[j] + " is prime number.");
            }
        }
    }
}
