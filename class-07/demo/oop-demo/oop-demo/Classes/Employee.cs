using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_demo.Classes
{
    /// <summary>
    /// sub class of Person
    /// Concrete class
    /// </summary>
    public abstract class Employee : Person
    {
        public override string Name { get; set; }
        public override int Age { get; set ; }

        public abstract int Salary { get; set; }
    }
}
