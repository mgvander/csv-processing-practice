using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make a new instance of the Employee class
            Employee myEmployee = new Employee();

            myEmployee.FirstName = "Michael";
            myEmployee.LastName = "VanderMyde";
            myEmployee.WeeklySalary = 250.45m;

            Console.WriteLine(myEmployee.ToString());

            myEmployee = new Employee(
                "John",
                "Smith",
                298.45m
                );

            Console.WriteLine(myEmployee.ToString());

            // Array of employees
            Employee[] employees = new Employee[10];

            // Adding some employees to our array
            employees[0] = new Employee("David", "Barnes", 835.00m);
            employees[1] = new Employee("James", "Kirk", 453.00m);
            employees[2] = new Employee("Jean-Luc", "Picard", 290.00m);
            employees[3] = new Employee("Benjamin", "Sisko", 587.00m);
            employees[4] = new Employee("Kathryn", "Janeway", 184.00m);
            employees[5] = new Employee("Jonathan", "Archer", 135.00m);
            employees[6] = new Employee("Carol", "Freeman", 123.00m);
            //employees[7] = new Employee();
            //employees[8] = new Employee();
            //employees[9] = new Employee();

        }
    }
}
