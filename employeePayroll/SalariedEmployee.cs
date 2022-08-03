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

namespace employeePayroll
{
    internal class SalariedEmployee : Employee
    {
        //Creating the field
        private double weeklySalary;

        //Creating the property
        public double WeeklySalary { get => weeklySalary; set => weeklySalary = value; }

        //Creating the constructor inherited from Employee
        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, double salary, double weeklySalary) : base(firstName, lastName, socialSecurityNumber, salary)
        {
            WeeklySalary = weeklySalary;
        }

        //Creating an override method ToString to return the employee's information
        public override string ToString()
        {
            return base.ToString() + $"\nWeekly Salary: {weeklySalary:C2}";
        }

        //Overriding the method to obtain the salary
        public override double Earnings()
        {
            return base.Earnings() + weeklySalary;
        }


    }
}
