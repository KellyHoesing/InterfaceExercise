using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -DONE

            //Create 3 classes called Car , Truck , & SUV -DONE

            //In your IVehicle -DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany -DONE

            /*Create 2 members that are specific to each every company -DONE
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes - DONE

            /*Create 2 members that are specific to each class - DONE
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            Car focus = new Car() { Logo = "blue oval", Make = "ford", Model = "focus", NumberOfTires = 4, Reputation = "Good", Year = 2000, HasTrunk = true, HowManyDoors = 4 };
            Car pontiac = new Car() { Logo = "paper airplane", Make = "pontiac", Model = "grand am", NumberOfTires = 4, Reputation = "Good", Year = 2004, HasTrunk = true, HowManyDoors = 4 };
            SUV rav = new SUV() { Logo = "Weird circle", Make = "Toyota", Model = "Rav4", NumberOfTires = 4, Reputation = "Bad", Year = 2016, HasCableMount = false, HowManyWheelDrive = 2 };
            SUV forerunner = new SUV() { Logo = "Ram's Head", Make = "Dodge", Model = "Ram", NumberOfTires = 4, Reputation = "Good", Year = 2018, HasCableMount = true, HowManyWheelDrive = 4 };
            Truck ridgeline = new Truck() { Logo = "Double Hockeysticks", Make = "Honda", Model = "Ridgeline", NumberOfTires = 4, Reputation = "Good", Year = 1998, CanSleep = false, RequireCert = false };
            Truck semiTrailer = new Truck() { Logo = "Bison Horns", Make = "Wabash", Model = "Long-Haul", NumberOfTires = 16, Reputation = "Bad", Year = 1974, CanSleep = true, RequireCert = true };
            //Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(focus);
            vehicles.Add(pontiac);
            vehicles.Add(rav);
            vehicles.Add(forerunner);
            vehicles.Add(ridgeline);
            vehicles.Add(semiTrailer);
            foreach(IVehicle vehicle in vehicles)
            {
                Console.WriteLine($"Year {vehicle.Year} Make {vehicle.Make} Model {vehicle.Model}");
                Console.WriteLine("---------------");
            }
        }
    }
}
