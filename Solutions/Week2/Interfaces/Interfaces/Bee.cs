using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
   abstract class Bee
    {
        string BeeType { get; set; }
        string Name { get; set; }

        string BeeName()
        {
            return Name;
        }
    }
}
