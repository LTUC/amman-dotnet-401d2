using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo_Inheritance
{
    abstract class Feline : Animal
    {
        public string Name { get; set; }
        public int Size { get; set; }
        public string Color { get; set; }

        public virtual void Play()
        {

        }

        public virtual void Sound()
        {

        }

    }
}
