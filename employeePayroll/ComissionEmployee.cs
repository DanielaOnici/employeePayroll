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
        public ComissionEmployee (string firstName, string lastName, string socialSecurityNumber, double comissionRate, double grossSale) : base(firstName, lastName, socialSecurityNumber)
        {
            ComissionRate = comissionRate;
            GrossSale = grossSale;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nComission Rate: {comissionRate:C}\nGross Sale: {grossSale:C}";
        }
    }
}
