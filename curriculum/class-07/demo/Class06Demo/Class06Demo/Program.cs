using Class06Demo.Interfaces;
using System;

namespace Class06Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        /*
         * 1. Start Demo by creating the Person Class
         * 2. Then create the Student and Employee. Use this opportunity to review the OOP principles
         * 
         * 3. Create an Interface named IDrive. Implement it onto the Employee class. This will require that the employee implement all of the method signatures that live in the interface. This is our "contract" that the interface makes with the compiler. 
         * 
         * 4. Now implement the IDrive interface onto the Robot class..because Robots can drive now. 
         * 
         * 5. There is no relationship between Robot and Employee..but now both can drive!
         * 
         * 6. Create a method in the Program class that accepts IDrive as a paramater. Now Employee and Robot can be accepted into it. 
         * 
         * 7. Create a new interface named IDrivable that make it implemented onto another few classes such as Boat and Airplane
         * 
         * 8. Now both a boat and an airplane are drivable....
         * 
         * 9. Let's make Robot Drivable too...to show that we can make a class have more than one interface attached to it...
         * 
         * 10. Finally make a new method in Employee to allow for anything that is IDrivable
         */

        /// <summary>
        /// Example for Demo to show polymophism using interfaces
        /// </summary>
        /// <param name="driver">Anything that implements the IDrive interface can be accepted as a driver</param>
        public static void IDriveExample(IDrive driver)
        {
            Console.WriteLine($"My License is from the state of {driver.StateLicense}");
            Console.WriteLine($"I adjust my settings by: {driver.AdjustSettings()}");
        }
    }
}
