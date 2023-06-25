using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Inheritance
{
    public class Vehicle
    {
        public string Color { get; set; }
        public string Model { get; set; }
        protected int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Starting the vehicle...");
            // Code for starting the vehicle
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the vehicle...");
            // Code for stopping the vehicle
        }

        public int GetYear() 
        {
            return Year;
        }

        public virtual void TurnRight()
        {
            // Implementation
            Console.WriteLine("Vehicle is turning right");
        }
    }
}
