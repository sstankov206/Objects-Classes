using System;
using System.Text;
namespace StoreBoxes.Models
{
    public class Box
    {//properties:

        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal PriceBox { get => Decimal.Multiply(this.Item.Price, new Decimal (this.ItemQuantity)); }

        //constructor:
        public Box()
        {
            Item = new Item();

            
        }

        

        //constructor with parametes:
        public Box(string serialNum, Item item, int qty)
        {
            this.SerialNumber = serialNum;
            this.Item = item;
            this.ItemQuantity = qty;
            
        }

        //override .ToString() method:
        public override string ToString()
        {

            return $"{this.SerialNumber}\n{this.Item.ToString()}: {this.ItemQuantity}\n--${this.PriceBox:F2}";

           // return $"{this.SerialNumber}\n--{this.Item.Name} –${this.Item.Price:F2}: {this.Quantity}\n--${this.PriceBox:F2}";

        }

    }
}

