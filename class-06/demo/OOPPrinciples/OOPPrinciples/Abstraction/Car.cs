using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Abstraction
{
    public class Car : Vehicle
    {
        public string Name { get; set; } = "Kia";
        public override void Move()
        {
            Console.WriteLine("The car is moving");
        }

        public override void Accelerate()
        {
            Console.WriteLine("The car is accelerating");
        }

        public override void Brake()
        {
            Console.WriteLine("The car is braking");
        }
    }

}
