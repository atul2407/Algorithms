using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    class MaxOccurenceNumerInArray
    {
        //This returns the number from array which is repeated more than 50% of array size.
        public static int GetNumberWhichOccursMoreThanHalfTimesInArray(int[] array)
        {
            //by lnq approach
            var result = array.GroupBy(g => new { g })
                .Select(
                c => new { number = c, count = c.Count() }
                )
                .Where(c => c.count > array.Length/2).Select(n => n.number).First().Key.g;

            //by dict approach
            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (int i in array)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;

                    if (dict[i] > array.Length / 2)
                    {
                        return i;
                    }
                }
                else
                {
                    dict.Add(i, 1);
                }
            }

            return 0;
        }
    }
}
