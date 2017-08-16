using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IProvider
    {
        string ProviderSaying { get; }
        void Scavenge();
        int NumberFound();
    }
}
