using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class PalindromeIndex
    {
        public static void HackerRankPalindromeIndexProb(string input)
        {
            char[] chars = input.ToCharArray();
            int count = input.Length;
            int mistachIndex = -1;
            for (int i = 0; i < (count+1)/2; i++)
            {
                if (chars[i] != chars[count - 1 - i])
                {
                    if (IsPalindrome(input.Substring(0, i) + input.Substring(i + 1)))
                    {
                        mistachIndex = i;
                        break;
                    }
                    else
                        mistachIndex = count - 1 - i;

                }
                
            }

            if (mistachIndex == -1)
                Console.WriteLine("All palindrome");
            else
                Console.WriteLine("Remove - " + chars[mistachIndex]);
            return;
        }

        public static bool IsPalindrome(string input)
        {
            return (input == string.Join("", input.Reverse().ToArray()));
        }
    }
}
