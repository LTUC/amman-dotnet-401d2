using System;
using Interfaces.Classes;
using Interfaces.Interfaces;

namespace Interfaces
{
  class Program
  {
    static void Main(string[] args)
    {
      Car mazda = new Car();
      Robot data = new Robot();
      Employee john = new Employee(1000000, "WA");
      john.Drive(mazda);

      data.Brake();
      IDriveExample(john);
    }

    public static void IDriveExample(IDrive driver)
    {
      Console.WriteLine($"My License is from the state of {driver.StateLicense}");
      Console.WriteLine($"I adjust my settings by: {driver.AdjustSettings()}");
    }
  }
}
