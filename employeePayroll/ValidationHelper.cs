using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace employeePayroll
{
    public class ValidationHelper
    {
        //Creating a method to validate name accepting at least 2 characters and no more than 12. No numbers or special characters are accepted
        public static Boolean ValidateName(string name)
        {
            Regex validName = new Regex(@"^[a-zA-Z]{2, 12}$");
            if (validName.IsMatch(name))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Creating a method to validate de SSN accepting only 5 numbers
        public static Boolean ValidateSSN(string socialSecurityNumber)
        {
            Regex validSSN = new Regex(@"^[0-9]{5}$");
            if (validSSN.IsMatch(socialSecurityNumber))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
