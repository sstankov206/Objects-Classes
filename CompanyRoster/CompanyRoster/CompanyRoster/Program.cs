//solution by me, sstankov.
using System.Linq;
using CompanyRoster.Models;

//determine 'N' number of lines of employees:
int n = int.Parse(Console.ReadLine());

//create List to store the employees in:
List<Employee> employees = new List<Employee>();


//iterate through the array:
for (int i = 0; i < n; i++)
{
    //create an array 'roster' w/ size of 'N' and split by space:
    string[] roster = new string[n];
    roster = Console.ReadLine().Split();

    //create new employee each iteration:
    Employee employee = new Employee(roster[0], roster[1], roster[2]); 
    
    employees.Add(employee); //add each newly create employee to the list 'employees'

}

IGrouping<string, Employee> grouping = employees
    .GroupBy(employee => employee.Department)
    .OrderByDescending(x => x.Sum(y => y.Salary))
    .First();
   
Console.WriteLine($"Highest Average Salary: {grouping.Key}\n{String.Join("\n", grouping.OrderByDescending(e=>e.Salary))}");




