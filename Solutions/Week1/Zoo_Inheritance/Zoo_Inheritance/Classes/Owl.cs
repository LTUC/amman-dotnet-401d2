using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Inheritance.Classes
{
    class Owl : Bird
    {
        public override void Swim()
        {
            // I can't swim
        }

        public override void Sleep()
        {
            //I sleep during the day
        }

        public override void Eat()
        {
           // My diet is different!
        }

        public override void MakeNoise()
        {
            //HOOT hooot
        }
    }
}
