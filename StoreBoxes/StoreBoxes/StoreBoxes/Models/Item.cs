using System;
using System.Text;

namespace StoreBoxes.Models
{
    public class Item
    {
        //properties:
        public string Name { get; set; }
        public decimal Price { get; set; }

        //constructor:
        public Item()
        {
        }

        //construtor with parameters:
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;

        }

        public override string ToString()
        {
            return $"--{this.Name} –${this.Price:F2}";
        }
    }
}

