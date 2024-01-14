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

        }
    }
}
