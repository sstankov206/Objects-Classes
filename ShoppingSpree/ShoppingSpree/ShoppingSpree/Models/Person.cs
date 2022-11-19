using System;
using System.Text;

namespace ShoppingSpree.Models
{
    public class Person
    {
        public string Name { get; set; }
        public double Money { get; set; }
        public List<Product> Bag = new List<Product>();

        public Person()
        {
        }

        public string BuyProduct(Product product)
        {
            var cantbuy = "can't afford";
            if (this.Money >= product.Cost)
            {
                this.Bag.Add(product);
                this.Money -= product.Cost;
                cantbuy = "bought";
            }
            return($"{this.Name} {cantbuy} {product.Name}");
            
        }

        public override string ToString()
        {
            string bag = "Nothing bought";
            if (this.Bag.Count > 0)
            {
                List<string> list = this.Bag
                    .Select(x => x.ToString())
                    .ToList();
                bag = String.Join(", ", list);
            }


            return $"{this.Name} - {bag}";
        }
    }

   
}

