using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_1
{
    internal class UserInterface
    {
        // No Variables
        // No Properties
        // No Construnctors (besides the default constructor)

        /**************************************************************
         * Methods
         * ***********************************************************/
        public int GetUserInput()
        {
            // Print out a menu
            this.PrintMenu();

            // Get the input from the user
            string input = Console.ReadLine();

            // Check for valid input
            while (input != "1" && input != "2")
            {
                // Print Error Message
                this.PrintErrorMessage();

                // Re-print Menu
                this.PrintMenu();

                // Get the input from the user
                input = Console.ReadLine();

            }

            // The user has provided valid input of either "1" or "2".
            // Return which ever string was input.
            return Int32.Parse(input);
        }

        public void PrintList(string outputList)
        {
            Console.WriteLine("Printing the List");
            Console.WriteLine("First Name \t Last Name \t Weekly Salary");
            Console.WriteLine(outputList);

        }

        private void PrintMenu()
        {
            // Options for user to pick from
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Print List");
            Console.WriteLine("2. Exit");

        }

        private void PrintErrorMessage()
        {
            Console.WriteLine("This in not a valid entry");
            Console.WriteLine("Please make a valid choice");
            Console.WriteLine();

        }

    }
}
