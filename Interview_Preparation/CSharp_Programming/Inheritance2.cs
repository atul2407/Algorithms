using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{

    class TestInheritance1
    { 
        public static void TestClass()
        {
            Maruti mar = new Maruti();
            mar.run();

            Car mar1 = new Maruti();
            mar1.run();

            Car mar2 = new Mahindra();
            mar2.run();
        }
    }

    class Car
    {

        public virtual void run()
        {

            Console.WriteLine("Car is running");
        }

    }

    class Maruti : Car
    {

        public void run()
        {

            Console.WriteLine("Maruti Car is running");
        }

    }

    class Mahindra : Car
    {

        public override void run()
        {

            Console.WriteLine("Mahindra Car is running");
        }

    }
}
