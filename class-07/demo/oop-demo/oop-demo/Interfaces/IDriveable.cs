using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo.Interfaces
{
    public interface IDriveable
    {
        void Start();
        void Steer();

        void Accelerate();

        void Decelerate();

        void Stop();
    }
}
