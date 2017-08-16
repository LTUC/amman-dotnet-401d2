using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsExample
{

    internal class Product
    {
        public string Name { get; set; }

        public Product() { Name = "N/A"; }
        public Product(string n) { Name = n; }
    }

    class ProductList : List<Product>
    {
    }

}
