using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Inheritance.Classes
{
    class Lion : Feline
    {
        public override void MakeNoise()
        {
            Console.WriteLine("ROAR");
        }

        //public override void Eat()
        //{
        //    Console.WriteLine("EATT");
        //}
    }
}
