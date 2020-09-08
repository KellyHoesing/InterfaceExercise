using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : ICompany, IVehicle
    {
        public string Logo { get; set; }
        public string Reputation { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumberOfTires { get; set; }
        public int Year { get; set; }
        public bool HasCableMount { get; set; }
        public int HowManyWheelDrive { get; set; }
    }
}
