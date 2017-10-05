using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo19Tests.Models
{
    public class SimpleRepository : IRepository
    {
        private static SimpleRepository sharedRepository = new SimpleRepository();
        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static SimpleRepository SharedRepository => sharedRepository;

        public SimpleRepository()
        {
            var initialItems = new[]
            {
                new Product{ Name="Video Game", Price=60M},
                new Product{Name="TV", Price = 300m},
                new Product {Name = "CellPhone", Price = 600M}
        };
            foreach (var p in initialItems)
            {
                AddProduct(p);
            }
            products.Add("Error", null);

        }

        public IEnumerable<Product> Products => products.Values;
        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
