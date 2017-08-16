using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class ProviderBee : Bee, IProvider, IWorker
    {
        public string ProviderSaying { get; }
        public void Scavenge()
        {
            Console.WriteLine("I'm a Scavenger in Provider Bee Class");
        }
        public int NumberFound()
        {
            return 10;
        }

        public string WorkerSaying { get; }
        public void Actions()
        {
            Console.WriteLine("I'm the Actions Method in the Provider Bee Class");
        }
        public string Protect()
        {
            return "Protect Method from Worker bee Class";
        }

    }
}
