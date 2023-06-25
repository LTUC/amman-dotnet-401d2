using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples.Inheritance
{
    public class Motorcycle : Vehicle
    {
        public bool HasSidecar { get; set; }

        public void Wheelie()
        {
            Console.WriteLine("Performing a wheelie with the motorcycle...");
            // Code for performing a wheelie
        }

        public override void TurnRight()
        {
            //base.TurnRight();
            Console.WriteLine("Motorcycle is turning right");
        }
    }
}
