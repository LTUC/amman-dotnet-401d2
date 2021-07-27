using System;
using Interfaces.Interfaces;

namespace Interfaces.Classes
{
  public class Robot : IDrive, IDrivable
  {
    public int NumberOfEyes { get; set; }
    public string SerialNumber { get; set; }
    public string StateLicense { get; set; }

    public void Accelerate()
    {
      Console.WriteLine("Robots go fast");
    }

    public string AdjustSettings()
    {
      return "Beep Beep Boop Boop";
    }

    public void Brake()
    {
      Console.WriteLine("Robots stop for no one....");

    }

    public void Start()
    {
      Console.WriteLine("Robots are always on....");

    }

    public void Stop()
    {
      Console.WriteLine("Stop not found....");

    }

    public string TakeOverTheWorldPlan()
    {
      return "I will take over the world!!";
    }
  }
}
