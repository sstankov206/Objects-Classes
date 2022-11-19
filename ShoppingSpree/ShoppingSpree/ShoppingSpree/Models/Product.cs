using System;
namespace ShoppingSpree.Models
{
    public class Product
    {

        public string Name { get; set; }
        public double Cost { get; set; }

        public Product()
        {
        }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}

