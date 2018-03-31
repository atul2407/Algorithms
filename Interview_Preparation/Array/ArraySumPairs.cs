using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class TwoSum
    {

        //Time complexity: O(n)
        //Space complexity: O(n)
        //Table lookup time: O(1)
        public static int[] GetTwoInput(int[] input, int result)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < input.Length; i++)
            {
                dict.Add(input[i], i);
            }

            for (int j = 0; j < input.Length; j++)
            {
                int complement = result - input[j];
                if (dict.ContainsKey(complement) && dict[complement] != j)
                { 
                    return new int[] { j, dict[complement] };
                }
            }

            throw new Exception("No solution");
        }

        //Time complexity: O(n)
        //Space complexity: O(n)
        //Table lookup time: O(1)
        public static int[] GetTwoInputApproach2(int[] input, int result)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int j = 0; j < input.Length; j++)
            {
                int complement = result - input[j];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { j, dict[complement] };
                }

                dict.Add(input[j], j);
            }

            throw new Exception("No solution");
        }

    }
}
