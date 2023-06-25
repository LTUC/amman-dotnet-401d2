using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Abstraction
{
    public abstract class Vehicle
    {
        public abstract void Move();
        public abstract void Accelerate();
        public virtual void Brake()
        {
            Console.WriteLine("The Vehicle is braking");
        }
    }
}
