using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class FunnyString
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        public static string CheckFunny(string input)
        {
            char[] chars = input.ToCharArray();
            int count = input.Length;
            bool isFunny = true;
            for(int i = 1; i < count; i++)
            {
                if (Math.Abs(chars[i] - chars[i - 1]) == Math.Abs(chars[count - i] - chars[count - i - 1]))
                {

                }
                else
                {
                    isFunny = false;
                }
            }

            return isFunny ? "Funny" : "Not Funny";
        }
    }
}
