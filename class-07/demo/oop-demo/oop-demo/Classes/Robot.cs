using oop_demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo.Classes
{
    public class Robot : IDrive, IDriveable
    {
        public string Licence { get ; set; }

        public void Accelerate()
        {
            Console.WriteLine("I am Accelerating");
        }

        public string AdjustSettings()
        {
            return "Settings are Adjust, I am a Robot";
        }

        public void Decelerate()
        {
            Console.WriteLine("I am Decelerating");
        }

        public void Start()
        {
            Console.WriteLine("I am starting");
        }

        public void Steer()
        {
            Console.WriteLine("I am Steering");
        }

        public void Stop()
        {
            Console.WriteLine("I am Steeringing");
        }
    }
}
