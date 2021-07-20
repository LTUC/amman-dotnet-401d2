using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car john = new Car(4);
            john.Drive();
        }
    }

    public class Vehicle
    {
        public int Wheels { get; set; }

        public void Drive() {
            Console.WriteLine($"{Wheels} wheels are moving");
	    }
    }

    public class Car : Vehicle {
        public Car( int wheels )
	    {
            Wheels = wheels;
	    }
    }
}
