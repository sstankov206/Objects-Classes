using System;
using System.Text;

namespace OrderByAge.Models
{
	public class Person
	{
		public string Name { get; set; }
		public string ID { get; set; }
		public int Age { get; set; }
		

		public Person(string name, string id, int age)
		{
			this.Name = name;
			this.ID = id;
			this.Age = age;

		}

		public Person()
		{ 
        }


        //override ToString() :

        public override string ToString()
		{

			return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}

