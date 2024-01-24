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
            //// Make a new instance of the Employee class
            //Employee myEmployee = new Employee();

            //myEmployee.FirstName = "Michael";
            //myEmployee.LastName = "VanderMyde";
            //myEmployee.WeeklySalary = 250.45m;

            //Console.WriteLine(myEmployee.ToString());

            //myEmployee = new Employee(
            //    "John",
            //    "Smith",
            //    298.45m
            //    );

            //Console.WriteLine(myEmployee.ToString());

            //// Array of employees
            //Employee[] employees = new Employee[10];

            //// Adding some employees to our array
            //employees[0] = new Employee("David", "Barnes", 835.00m);
            //employees[1] = new Employee("James", "Kirk", 453.00m);
            //employees[2] = new Employee("Jean-Luc", "Picard", 290.00m);
            //employees[3] = new Employee("Benjamin", "Sisko", 587.00m);
            //employees[4] = new Employee("Kathryn", "Janeway", 184.00m);
            //employees[5] = new Employee("Jonathan", "Archer", 135.00m);
            //employees[6] = new Employee("Carol", "Freeman", 123.00m);
            ////employees[7] = new Employee();
            ////employees[8] = new Employee();
            ////employees[9] = new Employee();

            /**********************************************************
             * Everything before this line is meant just for demo
             * purposes.
             * *******************************************************/

            // Make a new instance of an Employee type array
            Employee[] employees = new Employee[10];

            // Make a new instance of the UserInterface class.
            UserInterface uI = new UserInterface();

            // Path to the .csv file
            string pathToCSVFile = "../../../employees.csv";

            // Make a new instance of the CSVProcessor class.
            CSVProcessor cSVProcessor = new CSVProcessor();

            // Call the ImportCSV method passing in our path to the file and the array of employees
            cSVProcessor.ImportCSV(pathToCSVFile, employees);

            

            // Get user input
            int choice = uI.GetUserInput();

            // While the choice selected is not 2, continue to prompt
            // do work and prompt the user.
            while (choice != 2)
            {
                if (choice == 1)
                {
                    // Create a string that can be concatonated to
                    string outputString = "";

                    // Convert each employee to a string and add it to
                    // the output string
                    foreach (Employee employee in employees)
                    {
                        if (employee != null)
                        {
                            // Concatonate to the output string
                            outputString += employee.ToString()
                                          + Environment.NewLine;

                        }
                    }
                    // Use the UserInterface class to print out the
                    uI.PrintList(outputString);
                    
                }
                // Get user input
                choice = uI.GetUserInput();

            }
        }
    }
}
