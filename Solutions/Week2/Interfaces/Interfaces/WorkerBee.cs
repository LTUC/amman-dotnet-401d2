using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class WorkerBee: Bee, IWorker, IProvider
    {
        public string WorkerSaying { get; }
        public void Actions()
        {
            Console.WriteLine("I'm the Actions Method");
        }
        public string Protect()
        {
            return "Protect Method from Worker bee Class";
        }

        public string ProviderSaying { get; }
        public void Scavenge()
        {
            Console.WriteLine("I'm a Scavenger in Worker Bee Class");
        }
        public int NumberFound()
        {
            return 11;
        }
    }
}
