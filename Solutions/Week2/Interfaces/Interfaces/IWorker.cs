using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IWorker
    {
        string WorkerSaying { get; }
        void Actions();
        string Protect();
    }
}
