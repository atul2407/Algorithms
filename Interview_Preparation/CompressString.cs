using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    public class CompressString
    {
        public static void CompressStringInput(string input = "aaabbcccddef")
        {
            char currentChar = input[0];
            int charCount = 1;
            StringBuilder result = new StringBuilder();

            for (int i = 1; i <= input.Length; ++i)
            {
                if (i == input.Length)
                {
                    result.Append(currentChar);
                    if (charCount > 1)
                        result.Append(charCount);
                    break;
                }

                if (input[i] == currentChar)
                    charCount++;
                else
                {
                    result.Append(currentChar);
                    if (charCount > 1)
                        result.Append(charCount);

                    currentChar = input[i];
                    charCount = 1;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
