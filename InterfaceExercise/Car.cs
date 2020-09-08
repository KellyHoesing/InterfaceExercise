using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : ICompany, IVehicle
    {
        public string Logo { get; set; }
        public string Reputation { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfTires { get; set; }
        public int Year { get; set; }
        public bool HasTrunk { get; set; }
        public int HowManyDoors { get; set; }
    }
}
