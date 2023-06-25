using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Inheritance
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }
        



        public void Accelerate()
        {
            Console.WriteLine("Accelerating the car...");
            // Code for accelerating the car
        }

        public void Brake()
        {
            Console.WriteLine("Applying brakes to the car...");
            // Code for braking the car
        }

        public int GetYear()
        {
            return base.Year;
        }
    }

}
