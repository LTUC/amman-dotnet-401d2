using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample.Classes.Example3
{
    abstract class Document
    {
       
        public string Name { get; set; }

        //Abstract method is for polymorphism. Wil be overridden in derived classes
        // Abstract methods are REQUIRED to be overriden
        public abstract string Show();

        //Virtual methods are optional to be overriden
        public virtual string Hide()
        {
            return "This is now hidden";
        }

    }
}
