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
    internal class HourlyEmployee : Employee
    {
        //Creating the fields
        private double wage, hours;

        //Creating the properties
        public double Wage { get => wage; set => wage = value; }
        public double Hours { get => hours; set => hours = value; }  

        //Creating the constructor inherited from Employee
        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double salary, double wage, double hours) : base (firstName, lastName, socialSecurityNumber, salary) 
        {
            Wage = wage;
            Hours = hours;
        }

        //Creating an override method ToString to return the employee's information
        public override string ToString()
        {
            return base.ToString() + $"\nWage: {wage:C2}\nHours: {hours:N1}";
        }

        //Overriding the method to obtain the salary
        public override double Earnings()
        {
            if(hours <= 40)
            {
                return base.Earnings() + (wage * hours);
            }
            else if(hours > 40)
            {
                return base.Earnings() + (40 * wage) + ((hours - 40) * (wage * 1.5)) ;
            }
            else
            {
                return base.Earnings();
            }
        }
    }
}
