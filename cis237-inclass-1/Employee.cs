using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass_1
{
    internal class Employee
    {
        /**************************************************************
         * Attributes/Variables/Backing Fields
         * ***********************************************************/
        private string _firstName;
        private string _lastName;
        private decimal _weeklySalary;

        /**************************************************************
         * Properties
         * ***********************************************************/
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }

        /**************************************************************
         * Methods
         * ***********************************************************/
        public string FirstAndLastName()
        {
            return _firstName + " " + _lastName;
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName + " " + _weeklySalary;
        }

        /**************************************************************
         * Constructors
         * ***********************************************************/
        // Parameterless constructor for when an instance of the
        // Employee Class is created with no arguements to pass in.
        public Employee()
        {

        }

        // Constructor for when an instance of the Employee Class is
        // created while passing in the names and salary.
        public Employee(string passFirstName, string passLastName, decimal passWeeklySalary)
        {
            this._firstName = passFirstName;
            this._lastName = passLastName;
            this._weeklySalary = passWeeklySalary;
        }

    }
}
