﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicle = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var Accord = new Car() { Hastrunk = true, Make  =   "Honda",  Model = "Accord", Year = 2020};
            var motorcycle = new Motorcycle() { HasSideCar = true, Make = "Honda", Model = "Goldwing", Year = 2010 };

            Vehicle Jeep = new Car { Make = "Jeep", Model = "CJ", Year = 1990 };
            Vehicle SUV = new Car { Hastrunk = false,  Make = "Ford",  Model = "Bronco",  Year = 2021 };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicle.Add(Accord);
            vehicle.Add(motorcycle);
            vehicle.Add(Jeep);
            vehicle.Add(SUV);

            foreach(var veh in vehicle)
            {
                Console.WriteLine($"Make {veh.Make} Model {veh.Model} year{veh.Year} ");
                veh.DriveAbstract();
                Console.WriteLine("------------------------------------------------------------");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
