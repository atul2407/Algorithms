using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class StringPermutation
    {
        public static void GetStringPermutation(string input)
        {
            FindPermutations(input, "");

        }

        public static void FindPermutations(string input, string prefix)
        {
            Console.WriteLine("input ->" + input + ", prefix -> " + prefix);

            if (input.Length == 0)
                Console.WriteLine(prefix);
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string rem = input.Substring(0, i) + input.Substring(i + 1);
                    FindPermutations(rem, prefix + input[i]);
                }
            }

        }
    }
}
