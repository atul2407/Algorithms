using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class LinkedListSumPairs
    {

        //Time complexity: O(n)
        //Space complexity: O(n)
        //Table lookup time: O(1)
        public static void GetSumPairs(int[] input, int sum)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(input[0]);
            for(int i = 1; i < input.Length; i++)
            {
                list.AddLast(input[i]);

            }
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<int, int> result = new Dictionary<int, int>();

            LinkedListNode<int> pointer = list.First;

            while (pointer != null)
            {
                int difference = sum - pointer.Value;

                if (dict.ContainsKey(difference))
                {
                    result.Add(pointer.Value, difference);
                }

                dict.Add(pointer.Value, 0);
                pointer = pointer.Next;
            }

            var ret = result;
        }
    }
}
