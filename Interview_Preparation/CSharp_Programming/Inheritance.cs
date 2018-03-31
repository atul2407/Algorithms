using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Interview_prep
{
    class Class1
    {

    }

    class Class2 : Class1
    { 
    
    }

    public class TestClass
    {
        public static bool TestCompat()
        {
            Class1 cls = new Class2();
            return cls is Class1;
        }

        public static object GetDefault()
        {
            var s = default(string);
            var d = default(dynamic);
            var i = default(int);
            var n = default(int?); // n is a Nullable int where HasValue is false.

            return s;
        }

        //public static bool TestCompat1()
        //{
        //    Class2 cls = new Class1();
        //    return Class1 is Class1;
        //}
    }
}
