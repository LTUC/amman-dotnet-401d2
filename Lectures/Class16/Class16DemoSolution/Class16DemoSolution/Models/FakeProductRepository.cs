using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class16DemoSolution.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name = "Borderlands", Price = 50},
            new Product {Name = "Tomb Raider", Price = 75},
            new Product {Name = "Jak & Daxter", Price = 25}
        };
    }
}
