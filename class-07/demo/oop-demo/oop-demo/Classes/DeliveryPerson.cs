using oop_demo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo.Classes
{
    public class DeliveryPerson : Person, IDrive
    {
        public override string Name { get; set; }
        public override int Age { get; set; }
        public string Licence { get ; set ; }

        public string AdjustSettings()
        {
            return "My mirrors are good and the seat is right";
        }

        public string Deliver(IDriveable vehicle)
        {
            vehicle.Start();
            vehicle.Accelerate();
            vehicle.Steer();
            vehicle.Decelerate();
            vehicle.Stop();

            return "Package was delived";

        }
    }
}
