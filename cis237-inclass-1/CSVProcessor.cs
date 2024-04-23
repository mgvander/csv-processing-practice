using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_1
{
    internal class CSVProcessor
    {
        // No variables, properties, or constructors

        /**************************************************************
         * Methods
         * ***********************************************************/
        
        /// <summary>
        /// Read in a .csv file and use the contents to populate an
        /// array of Employees.
        /// </summary>
        /// <param name="pathToCSVFile"> Path to the .csv file to be read in </param>
        /// <param name="employees"> Array of Employees to populate </param>
        /// <returns> Whether the actions were successful or not </returns>
        public bool ImportCSV(string pathToCSVFile, Employee[] employees)
        {
            // Declare stream reader
            StreamReader streamReader = null;

            try
            {
                // Declare a string for a line read in
                string line;

                // Create an instance of streamReader
                streamReader = new StreamReader(pathToCSVFile);

                // Create a counter
                int counter = 0;

                //While we are still reading a line from the file
                while ((line = streamReader.ReadLine()) != null)
                {
                    this.ProcessLine(line, employees, counter++);

                }

                // We made it through the whole file with no complications
                return true;

            }
            catch (Exception e)
            {
                // Output the exception and tech stacktrace for the exception
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                // We did not make through the whole file with no complications
                return false;
            }
            finally
            {
                // If the stream reader was instantiated, make sure it is closed
                // before exiting the reader
                if (streamReader != null)
                {
                    // Close the stream reader
                    streamReader.Close();

                }

            }

        }

        /// <summary>
        /// Convert line to Employee instance and insert into Employee array.
        /// </summary>
        /// <param name="line"> Line to process </param>
        /// <param name="employees"> Array to insert into </param>
        /// <param name="index"> Index at which to do the insertion </param>
        private void ProcessLine(string line, Employee[] employees, int index)
        {
            // Declare array of parts that will contain the results of splitting the read in string
            string[] parts = line.Split(',');

            // Assign each part to a variable
            string firstName = parts[0];
            string lastName = parts[1];
            decimal weeklySalaray = decimal.Parse(parts[2]);

            // Add a new employee into the array
            employees[index] = new Employee(firstName, lastName, weeklySalaray);

        }

    }

}
