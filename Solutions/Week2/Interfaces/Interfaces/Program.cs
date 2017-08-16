using System;

namespace Interfaces
{
    class Program
    {
        /* 
       

         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Queen queen = new Queen();
            ProviderBee pb = new ProviderBee();


            queen.Collection(pb);
            pb.Scavenge();
            Console.Read();
            
        
        }
    }
}