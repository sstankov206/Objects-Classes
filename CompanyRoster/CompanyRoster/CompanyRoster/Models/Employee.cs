using System;
namespace CompanyRoster.Models
{
	public class Employee
	{
		public string  Name { get; set; }
		public decimal Salary { get; set; }
		public string Department { get; set; }

		public Employee(string name, string salary, string department)
		{
			this.Name = name;
			this.Salary = decimal.Parse(salary);
			this.Department = department;
		}

		public Employee()
		{
		}

        public override string ToString()
        {
            return $"{Name} {Salary}";
        }
    }
}

