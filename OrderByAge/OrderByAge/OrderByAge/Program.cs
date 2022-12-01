//solution by me, sstankov
using OrderByAge.Models;
using System.Text;

//create a list of the 'Person' class to store new 'people' :
List<Person> people = new List<Person>();

//reading input:
string command = Console.ReadLine();

//while input ISN'T = "End" :
while (!command.Equals("End"))
{
    //create array from input, split by space:
    string[] input = command.Split();

    //create new instance of 'person':
    Person person = new Person();

    person.Name = input[0]; //get person's name
    person.ID = input[1]; //get person's ID
    person.Age = int.Parse(input[2]); //get person's age

    //add new person to the list 'people' :
    people.Add(person);

    command = Console.ReadLine();
}

//output:
people
    .OrderBy(person=>person.Age)
    .ToList()

    .ForEach(person=>
Console.WriteLine(person.ToString()));

var result = String.Join(Environment.NewLine, people);
Console.WriteLine(result);
