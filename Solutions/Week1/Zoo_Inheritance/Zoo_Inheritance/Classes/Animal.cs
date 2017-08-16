using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Inheritance
{
    abstract class Animal
    {
        public string Food { get; set; }
        public int Hunger { get; set; }
        public decimal Boundaries { get; set; }
        public string Location { get; set; }

        public abstract void MakeNoise();

        public virtual void Eat()
        {
            Console.WriteLine("EATTTT");
        }

        public virtual void Sleep()
        {

        }

        public virtual void Roam()
        {
            Console.WriteLine("ROAM");

        }





    }

}
