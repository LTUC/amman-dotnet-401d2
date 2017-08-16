using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Inheritance
{
    abstract class Canine : Animal
    {
        public override void Eat()
        {
            //We eat different food
        }

        public override void Sleep()
        {
            //Different sleep scheudles!
        }

        public override void MakeNoise()
        {
            Console.WriteLine("ROAR");
        }
    }
}
