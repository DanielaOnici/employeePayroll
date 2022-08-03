/*  employeePayroll.sln
 * 
 *  The program calculates the payroll of the employees.
 *  Practice of inheritance and polymorphism.
 * 
 *  Daniela Onici
 *  Student ID# 8754297
 *  
 *  2022/08/03: created
 *  2022/08/04: finished
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace employeePayroll
{
    internal class Employee
    {
        //Creating private fields
        private string firstName, lastName, socialSecurityNumber;
        private double salary;

        //Creating properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string SSN { get => socialSecurityNumber; set => socialSecurityNumber = value; }
        public double Salary { get => salary; set => salary = value; }

        //Creating the constructor
        public Employee (string firstName, string lastName, string socialSecurityNumber, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = socialSecurityNumber;
            Salary = salary;
        }

        //Creating an override method ToString to return the employee's information
        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}\nSSN: {socialSecurityNumber}";
        }

        //Creating a method to be overriden
        public virtual double Earnings()
        {
            return salary;
        }

    }
}
