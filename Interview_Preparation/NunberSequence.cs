using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class NumberSequence
    {
        ///This is "Separate the Numbers" program from hackerrank. It checks the numbers sequence in string and see if all adjacent number is +1 i.e. 1 more than previous. Then print "Yes".
        ///For e.g. 99100 = 99 & 100 = YES.
        ///For e.g. 1234 = 1,2,3,4 = YES.
        ///For e.g. 9101112 = 9,10,11,12 = YES
        ///For e.g. 999111 = NO
        public static string EvaluateIfIncrementSequence(int[] inputList)
        {
            

            for (int a = 0; a < inputList.Length; a++)
            {
                int input = inputList[a];
                String s = input.ToString();
		        bool valid = false;
		        long firstx = -1;

                for (int i = 1; i <= s.Length / 2; ++i)
                {
                    long x = long.Parse(s.Substring(0, i));
                    firstx = x;

                    String test = x.ToString();
                    while (test.Length < s.Length)
                    {
                        test += (++x).ToString();
                    }

                    if (test.Equals(s))
                    {
                        valid = true;
                        break;
                    }
                }
                Console.WriteLine(input.ToString() + " --> " + valid.ToString());

                
            }

            return "";
        }
    }
}
