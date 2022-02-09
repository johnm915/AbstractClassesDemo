using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public abstract class Vehicle
    {
        public int  Year { get; set; } = 1;
        public string  Make { get; set; } = "default Make";
        public string  Model { get; set; } = "default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is in vertual drive");
        }

    }
}
