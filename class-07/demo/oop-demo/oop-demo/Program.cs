using oop_demo.Classes;
using oop_demo.Interfaces;

namespace oop_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();

            Developer developer = new Developer();
           // developer.
            developer.Salary = 20000;
            developer.Name = "Test";
            developer.Age = 30;
            Console.WriteLine($"developer make {developer.Salary} per year");




            DeliveryPerson deliveryPerson = new DeliveryPerson()
            { Name = "deliveryPerson number 1" , Licence = "111111"};

            deliveryPerson.AdjustSettings();

            ValidateDriver(deliveryPerson);

            //ValidateDriver(developer);

            Console.Write("*************************");

            Boat boat = new Boat() { BoatName = "Boat number 1"};

            Robot robot = new Robot();

            deliveryPerson.Deliver(robot);

           


        }

        public static void ValidateDriver(IDrive driver)
        {
            Console.WriteLine($"License Information {driver.Licence}");

            Console.WriteLine($"I Adjust the vehciale {driver.AdjustSettings()}");

        }
    }
}