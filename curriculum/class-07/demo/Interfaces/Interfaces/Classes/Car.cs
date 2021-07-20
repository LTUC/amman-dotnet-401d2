using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Car : IDrivable
  {
    public void Accelerate()
    {
      Console.WriteLine("Hammer Down!");
    }

    public void Brake()
    {
      Console.WriteLine("Stomp on It");
    }

    public void Start()
    {
      Console.WriteLine("Turn that Key");
    }

    public void Stop()
    {
      Console.WriteLine("STOP!!!");
    }
  }
}
