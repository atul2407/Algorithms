using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    class ClassLikeString
    {
        private static string _value = null;
        public ClassLikeString(string value) 
        {
            _value = value;
        }

        public static void PrintValue()
        {
            Console.WriteLine(_value);
        }

        public static implicit operator ClassLikeString(string value)
        {
            return new ClassLikeString(value);
        }
    }
}
