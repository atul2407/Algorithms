using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Preparation
{
    public class IsPermutationsOfPalindrome
    {
        public static bool IsPalindromeFromPermutations(string input)
        {
            int countOdd = 0;
            int a = (int)'a';
            int b = (int)'z';
            int[] charCount = new int[b - a + 1];

            foreach (char c in input.ToCharArray())
            {
                int x = (int)c - a;
                if (x != -1)
                {
                    charCount[x]++;
                    if (charCount[x] % 2 == 1)
                    {
                        countOdd++;
                    }
                    else
                        countOdd--;
                }
            }

            if (countOdd <= 1)
                Console.WriteLine("input is permutation of palindrome");
            else
                Console.WriteLine("input is not permutation of palindrome");

            return countOdd <= 1;
        }
    }
}
