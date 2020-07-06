using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Truck : Vehicle
    {
        public Truck()
        {

        }

        public bool HasSideSteps { get; set; } = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This truck is in drive!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");

        }
    }
}
