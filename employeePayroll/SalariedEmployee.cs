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
        public SalariedEmployee(string firstName, string lastName, string socialSecurityNumber, double weeklySalary) : base(firstName, lastName, socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nWeekly Salary: {weeklySalary:C}";
        }
    }
}
