using System;
using System.Collections.Generic;
using Zoo_Inheritance.Classes;

namespace Zoo_Inheritance
{
    // Create a Zoo simulator. 
    /*
     Create a zoo simulator that implements the following:
        1. Inheritance
        2. Abstraction

        Here's a hint when constructing your classes:
            1. IF the class is to broad, or useless to instantiate on it's own, make it abstract.
            Remever what abstract methods do, remember what concrete methods do.
            show case the different forms of inheritance you are creating

        Create a drawn out diagram of what your inheritance looks like
        label the Abstract classes with <abstract> above their name.

         */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Lion lion = new Lion();
            lion.Eat();
            lion.Roam();
            Console.Read();
            List<Lion> lions = new List<Lion>();

            lions.Add(lion);

            foreach(Lion l in lions)
            {
                Console.WriteLine(l.Name);
            }
        }
    }
}