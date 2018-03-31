using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_prep
{

    class TestInheritance3
    { 
        public static void TestClass()
        {
            WireLessDevice mar = new WireLessDevice();
            mar.run();

            Wifi mar0 = new Wifi();
            mar0.run();

            WireLessDevice mar1 = new Wifi();
            mar1.run();

            WireLessDevice mar2 = new Bluetooth();
            mar2.run();

            WireLessDevice mar3 = new WiSmart();
            mar3.run();

            WireLessDevice mar4 = new WiSmart();
            mar4.run();
        }
    }

    class WireLessDevice
    {
        public WireLessDevice()
        {
            Console.WriteLine("Wireless constructor");
        }

        public virtual void run()
        {

            Console.WriteLine("WireLessDevice is running");
        }

    }

    class Wifi : WireLessDevice
    {
        public Wifi()
        {
            Console.WriteLine("Wifi constructor");
        }

        public void run()
        {

            Console.WriteLine("Wifi-WireLessDevice is running");
        }

    }

    class Bluetooth : WireLessDevice
    {
        public Bluetooth()
        {
            Console.WriteLine("Bluetooth constructor");
        }

        public override void run()
        {

            Console.WriteLine("Bluetooth-WireLessDevice is running");
            //base.run();
        }

    }

    class WiSmart : Wifi
    {
        public WiSmart()
        {
            Console.WriteLine("WiSmart constructor");
        }

        public void run()
        {

            Console.WriteLine("WiSmart-WireLessDevice is running");
            //base.run();
        }
    }
}
