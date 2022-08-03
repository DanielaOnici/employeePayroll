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
    internal class ComissionEmployee : Employee
    {
        //Creating the field
        private double comissionRate, grossSale;

        //Creating the properties
        public double ComissionRate { get => comissionRate; set => comissionRate = value; }
        public double GrossSale { get => grossSale; set => grossSale = value; }

        //Creating the constructor inherited from Employee
        public ComissionEmployee (string firstName, string lastName, string socialSecurityNumber, double salary, double comissionRate, double grossSale) : base(firstName, lastName, socialSecurityNumber, salary)
        {
            ComissionRate = comissionRate;
            GrossSale = grossSale;
        }

        //Creating an override method ToString to return the employee's information
        public override string ToString()
        {
            return base.ToString() + $"\nComission Rate: {comissionRate:C2}\nGross Sale: {grossSale:C2}";
        }

        public override double Earnings()
        {
            return base.Earnings() + (comissionRate * grossSale);
        }
    }
}
