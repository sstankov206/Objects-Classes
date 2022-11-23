//solution by me, sstankov.
using System.Text;
using StoreBoxes.Models;

//read input:
string command = Console.ReadLine();

//new list of "Item" class that will store the items:
List<Box> boxes = new List<Box>();


//while input ISN'T = "end" :
while (!command.Equals("end"))
{
    string[] input = command.Split(); //splits input by space

    //create new instance of 'Box' each turn of the while cycle:
    Box box = new Box();
    

    box.SerialNumber = input[0]; //get S/N of item
    box.Item.Name = input[1]; //get name of item
    box.ItemQuantity = int.Parse(input[2]); //get quantity of item
    box.Item.Price = decimal.Parse(input[3]); //get price of item
    

   boxes.Add(box)  ; //add newly created item to the list


    command = Console.ReadLine();
}
//output, sorted descending by price and printed in the requested format:

boxes
    .OrderByDescending(s => s.PriceBox)
    .ThenByDescending(s => s.ItemQuantity)
    .Select(s => ($"{s.SerialNumber}\n--{s.Item.Name} –${s.Item.Price:F2}: {s.ItemQuantity}\n--${s.PriceBox:F2}"))
    .ToList().ForEach(x=>Console.WriteLine(x))
    ;





boxes
    .OrderByDescending(s => s.PriceBox)
    .ToList()
    .ForEach(s => Console.WriteLine($"{s.SerialNumber}\n--{s.Item.Name} –${s.Item.Price:F2}: {s.ItemQuantity}\n--${s.PriceBox:F2}"));