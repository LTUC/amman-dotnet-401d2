using oop_demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo.Classes
{
    public class Boat : IDriveable
    {
        public string BoatName { get; set; }

        public void Accelerate()
        {
            Console.WriteLine("Boat is Accelerating");
        }

        public void Decelerate()
        {
            Console.WriteLine("Boat is Decelerating");
        }

        public void Start()
        {
            Console.WriteLine("Boat is Starting");
        }

        public void Steer()
        {
            Console.WriteLine("Boat is Steering");
        }

        public void Stop()
        {
            Console.WriteLine("Boat is Stopping");
        }
    }
}
