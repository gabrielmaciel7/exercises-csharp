using System;
using System.Collections.Generic;
using System.Text;

namespace _8
{
    class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }

        public Product(string name, float price)
        {
            Name = name;
            Price = price;
        }
    }
}
