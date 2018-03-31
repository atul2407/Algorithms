using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class DecompressString
    {
        public static void DecompressCompressedString(string input = "M#5BCDEA#2N")
        {
            //char[] chars = input.ToCharArray();
            int count = input.Length;
            List<string> result = new List<string>();
            int index = 0;
            while (index < input.Length)
            { 
                int seperatorIndex = index+1;
                int numbersIndex = index+2;

                if (seperatorIndex >= input.Length)
                {
                    result.Add(input[index].ToString());
                    index++;
                }
                else if (seperatorIndex < input.Length && input[seperatorIndex].ToString() == "#")
                {
                    result.Add(new string(input[index], int.Parse(input[numbersIndex].ToString())));
                    index+=3;
                }
                else if (seperatorIndex < input.Length && input[seperatorIndex].ToString() != "#")
                {
                    result.Add(input[index].ToString());
                    index++;
                } 
            }
            Console.WriteLine(string.Join("", result.ToArray()));
            
        }
    }
}
