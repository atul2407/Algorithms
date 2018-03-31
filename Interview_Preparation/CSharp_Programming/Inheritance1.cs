using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{
    class TestInhtnce2
    {
        public static void TestClass()
        {
            L1 l1 = new L1();
            l1.f1();

            L1 l12 = new L2();
            l12.f1();

            L1 l13 = new L3();
            l13.f1();
        }
    }
    class L1
    {
        public virtual void f1()
        {
            Console.WriteLine("L1:f1()");
        }
    }

    class L2 : L1
    {
        public sealed override void f1()
        {
            Console.WriteLine("L2:f1()");
        }
    }
    class L3 : L2
    {
        //Below commented line gives compilation error as sealed method cant be overridden.

        //public override void f1()
        //{
        //    Console.WriteLine("L3:f1()");
        //}

        public void f1()
        {
            Console.WriteLine("L3:f1()");
        }
    }
}
