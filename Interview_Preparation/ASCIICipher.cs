using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    /// <summary>
    /// Hackerrank string Cipher text
    /// </summary>
    public class ASCIICipher
    {
        public static void CipherText(string input)
        {
            char[] chars = input.ToCharArray();
            List<string> result = new List<string>();
            for (int i = 0; i < chars.Length; i++)
            {
                int asciiCode = (int)chars[i];
                result.Add(((char)(asciiCode + 2)).ToString());
            }

            Console.WriteLine(string.Join("", result.ToArray()));
            return; //string.Join("", result.ToArray());
        }
    }
}
