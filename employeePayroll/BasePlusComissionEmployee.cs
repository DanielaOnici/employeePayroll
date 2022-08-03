using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeePayroll
{
    internal class BasePlusComissionEmployee : ComissionEmployee
    {
        //Creating the field
        private double baseSalary;

        //Creating the property
        public double BaseSalary { get => baseSalary; set => baseSalary = value; }

        //Creating the constructos inherited from ComissionEmployee/Employee
        public BasePlusComissionEmployee (string firstName, string lastName, string socialSecurityNumber, double comissionRate, double grossSale, double baseSalary) : base(firstName, lastName, socialSecurityNumber, comissionRate, grossSale)
        {
            BaseSalary = baseSalary;
        }

        //Creating an override method ToString to return the employee's information
        public override string ToString()
        {
            return base.ToString() + $"\nBase Salary: {baseSalary:C2}";
        }
    }
}
