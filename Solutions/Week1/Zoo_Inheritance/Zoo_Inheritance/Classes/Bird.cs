using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Inheritance.Classes
{
    class Bird : Animal
    {
        public int Wingspan { get; set; }

        public override void MakeNoise()
        {
            Console.WriteLine("Tweet Tweet");
        }
        public virtual void Fly()
        {

        }

        public virtual void Swim()
        {

        }

        public override void Eat()
        {
          // Eat
        }
    }
}
