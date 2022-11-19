using ShoppingSpree.Models;

List<Person> people = Console.ReadLine().Split(";")
    .Where(x=>!string.IsNullOrWhiteSpace(x))
 .Select(command =>
{
    string[] names = command.Split("=");
    return new Person()
    {
        Name = names[0],
        Money = double.Parse(names[1])
    };
}).ToList();


List<Product> products = Console.ReadLine().Split(";")
 .Where(x => !string.IsNullOrWhiteSpace(x))
    .Select(command =>
    {
        string[] items = command.Split("=");
        return new Product()
        {
            Name = items[0],
            Cost = double.Parse(items[1])
        };
    }).ToList();

string input = Console.ReadLine();
List<string> results = new();
while (!input.Equals("END"))
{   
    string[] inputs = input.Split(" ");
    Person? person = people.FirstOrDefault(p => p.Name.Equals(inputs[0]));
    if (person is not null)
    {
        Product? product = products.FirstOrDefault(p => p.Name.Equals(inputs[1]));
        if (product is not null)
        {
            string result = person.BuyProduct(product);
            results.Add(result);
        }
    }

    input = Console.ReadLine();
}
results.ForEach(x => Console.WriteLine(x));
people.ForEach(x=>Console.WriteLine(x.ToString()));