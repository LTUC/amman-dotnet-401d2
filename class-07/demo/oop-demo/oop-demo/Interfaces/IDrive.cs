using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo.Interfaces
{
    public interface IDrive
    {
        string Licence { get; set; }

        string AdjustSettings(); //change mirror , seat
    }
}
