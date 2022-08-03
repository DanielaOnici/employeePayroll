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
        public HourlyEmployee(string firstName, string lastName, string socialSecurityNumber, double wage, double hours) : base (firstName, lastName, socialSecurityNumber) 
        {
            Wage = wage;
            Hours = hours;
        }
    }
}
