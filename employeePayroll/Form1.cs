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

namespace employeePayroll
{
    public partial class Form1 : Form
    {
        //Instatiating objects of the classes
        SalariedEmployee newSalariedEmployee;
        ComissionEmployee newComissionEmployee;
        HourlyEmployee newHourlyEmployee;
        BasePlusComissionEmployee newBasePlusComissionEmployee;

        //Creating a method to check the first empty label to show the message and focus on the first error
        public void ErrorMessage(string message, Control control)
        {
            if (lblErrorMessageOne.Text == null || lblErrorMessageOne.Text == "")
            {
                lblErrorMessageOne.Text = message;
                control.Focus();
            }
            else if (lblErrorMessageTwo.Text == null || lblErrorMessageTwo.Text == "")
            {
                lblErrorMessageTwo.Text = message;
            }
            else if (lblErrorMessageThree.Text == null || lblErrorMessageThree.Text == "")
            {
                lblErrorMessageThree.Text = message;
            }
            else
            {
                lblErrorMessageFour.Text = message;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        //Defining the fields to be filled in for each type of employee
        private void cmbbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbType.SelectedIndex == 0)
            {
                txtbBaseSalary.Enabled = true;
                txtbWage.Enabled = false;
                txtbHours.Enabled = false;
                txtbComissionRate.Enabled = false;
                txtbGrossSales.Enabled = false;
            }
            else if(cmbbType.SelectedIndex == 1)
            {
                txtbBaseSalary.Enabled = false;
                txtbWage.Enabled = false;
                txtbHours.Enabled = false;
                txtbComissionRate.Enabled = true;
                txtbGrossSales.Enabled = true;
            }
            else if(cmbbType.SelectedIndex == 2)
            {
                txtbBaseSalary.Enabled = false;
                txtbWage.Enabled = true;
                txtbHours.Enabled = true;
                txtbComissionRate.Enabled = false;
                txtbGrossSales.Enabled = false;
            }
            else if(cmbbType.SelectedIndex == 3)
            {
                txtbBaseSalary.Enabled = true;
                txtbWage.Enabled = false;
                txtbHours.Enabled = false;
                txtbComissionRate.Enabled = true;
                txtbGrossSales.Enabled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   
            //Clearing the label messages before validating the fields
            lblErrorMessageOne.Text = "";
            lblErrorMessageTwo.Text = "";
            lblErrorMessageThree.Text = "";
            lblErrorMessageFour.Text = "";
            lblResult.Text = "";

            //Creating the variables
            string firstName = txtbFirstName.Text.Trim();
            string lastName = txtbLastName.Text.Trim();
            string SSN = txtbSSN.Text.Trim();
            string inputBaseSalary = txtbBaseSalary.Text.Trim();
            string inputWage = txtbWage.Text.Trim();
            string inputHours = txtbHours.Text.Trim();
            string inputComissionRate = txtbComissionRate.Text.Trim();
            string inputGrossSale = txtbGrossSales.Text.Trim();

            double salary = 0;
            double baseSalary = 0;
            double wage = 0;
            double hours = 0;
            double comissionRate = 0;
            double grossSale = 0;

            //Validating first name
            if (ValidationHelper.ValidateName(firstName) == true)
            {
                firstName = ValidationHelper.Capitalize(firstName);
            }
            else
            {
                ErrorMessage("Invalid First Name. Min 2 characters and max 12 without numbers or special characters", txtbFirstName);
            }

            //Validating last name
            if (ValidationHelper.ValidateName(lastName) == true)
            {
                lastName = ValidationHelper.Capitalize(lastName);
            }
            else
            {
                ErrorMessage("Invalid Last Name. Min 2 characters and max 12 without numbers or special characters", txtbLastName);

            }

            //Validating SSN
            if(ValidationHelper.ValidateSSN(SSN) == true)
            {
            }
            else
            {
                ErrorMessage("Invalid SSN. Must be a sequence of 5 numbers", txtbSSN);
            }

            //Validating baseSalary
            if (cmbbType.SelectedIndex == 0)
            {
                try
                {
                    baseSalary = double.Parse(inputBaseSalary);
                    if(baseSalary <= 0)
                    {
                        ErrorMessage("Invalid Base Salary. Must be greater than 0", txtbBaseSalary);
                    }
                }   
                catch(Exception)
                {
                    ErrorMessage("Invalid Base Salary. Cannot be empty and must be a number", txtbBaseSalary);
                }
            }
            //Validating comission rate and gross sale
            else if (cmbbType.SelectedIndex == 1)
            {
                try
                {
                    comissionRate = double.Parse(inputComissionRate);
                    if(comissionRate <= 0)
                    {
                        ErrorMessage("Invalid Comission Rate. Must be greater than 0", txtbComissionRate);
                    }
                }
                catch(Exception)
                {
                    ErrorMessage("Invalid Comission Rate/Gross Sales. Cannot be empty and must be only a number", txtbComissionRate);
                }
                try
                {
                    grossSale = double.Parse(inputGrossSale);
                    if (grossSale <= 0)
                    {
                        ErrorMessage("Invalid Gross Sales. Must be greater than 0", txtbGrossSales);
                    }
                }
                catch(Exception)
                {
                    ErrorMessage("Invalid Gross Sales. Cannot be empty and must be only a number", txtbGrossSales);
                }
                
            }
            //Validating wage and hours
            else if (cmbbType.SelectedIndex == 2)
            {
                try
                {
                    wage = double.Parse(inputWage);
                    if(wage <= 0)
                    {
                        ErrorMessage("Invalid Wage. Must be greater than 0", txtbWage);
                    }
                }
                catch(Exception)
                {
                    ErrorMessage("Invalid Wage. Cannot be empty and must be only a number", txtbWage);
                }
                try
                {
                    hours = double.Parse(inputHours);
                    if (hours <= 0)
                    {
                        ErrorMessage("Invalid Hours. Must be greater than 0", txtbHours);
                    }
                }
                catch(Exception)
                {
                    ErrorMessage("Invalid Hours. Cannot be empty and must be only a number", txtbHours);
                }
                
            }
            else if(cmbbType.SelectedIndex == 3)
            {
                try
                {
                    baseSalary = double.Parse(inputBaseSalary);
                    if (baseSalary <= 0)
                    {
                        ErrorMessage("Invalid Base Salary. Must be greater than 0", txtbBaseSalary);
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Invalid Base Salary. Cannot be empty and must be a number", txtbBaseSalary);
                }
                try
                {
                    comissionRate = double.Parse(inputComissionRate);
                    if (comissionRate <= 0)
                    {
                        ErrorMessage("Invalid Comission Rate. Must be greater than 0", txtbComissionRate);
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Invalid Comission Rate/Gross Sales. Cannot be empty and must be only a number", txtbComissionRate);
                }
                try
                {
                    grossSale = double.Parse(inputGrossSale);
                    if (grossSale <= 0)
                    {
                        ErrorMessage("Invalid Gross Sales. Must be greater than 0", txtbGrossSales);
                    }
                }
                catch (Exception)
                {
                    ErrorMessage("Invalid Gross Sales. Cannot be empty and must be only a number", txtbGrossSales);
                }
            }

            //Displaying a message of error if no type is selected
            if (cmbbType.SelectedIndex == -1)
            {
                ErrorMessage("You must select the type of the employee.", cmbbType);
            }

            //Displaying the employee's information if no error occurs
            if(lblErrorMessageOne.Text.Length == 0)
            {
                //Displaying the Salaried employee's information
                if (cmbbType.SelectedIndex == 0)
                {
                    newSalariedEmployee = new SalariedEmployee(firstName, lastName, SSN, salary, baseSalary);
                    lblResult.Text = $"{newSalariedEmployee.ToString()}";
                }
                //Displaying the Comission employee's information
                else if (cmbbType.SelectedIndex == 1)
                {
                    newComissionEmployee = new ComissionEmployee(firstName, lastName, SSN, salary, comissionRate, grossSale);
                    lblResult.Text = $"{newComissionEmployee.ToString()}\nTotal salary: {newComissionEmployee.Earnings().ToString("C2")}";
                }
                //Displaying the Hourly employee's information
                else if (cmbbType.SelectedIndex == 2)
                {
                    newHourlyEmployee = new HourlyEmployee(firstName, lastName, SSN, salary, wage, hours);
                    lblResult.Text = $"{newHourlyEmployee.ToString()}\nTotal salary: {newHourlyEmployee.Earnings().ToString("C2")}";
                }
                //Displaying the Base Plus Comission employee's information
                else if (cmbbType.SelectedIndex == 3)
                {
                    newBasePlusComissionEmployee = new BasePlusComissionEmployee(firstName, lastName, SSN, salary, comissionRate, grossSale, baseSalary);
                    lblResult.Text = $"{newBasePlusComissionEmployee.ToString()}\nTotal salary: {newBasePlusComissionEmployee.Earnings().ToString("C2")}";
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Clearing all the label messages
            lblErrorMessageOne.Text = "";
            lblErrorMessageTwo.Text = "";
            lblErrorMessageThree.Text = "";
            lblErrorMessageFour.Text = "";
            lblResult.Text = "";

            //Clearing all the fields
            txtbFirstName.Clear();
            txtbLastName.Clear();
            txtbSSN.Clear();
            txtbBaseSalary.Clear();
            txtbWage.Clear();
            txtbHours.Clear();
            txtbComissionRate.Clear();
            txtbGrossSales.Clear();

            //Clearing the combo box
            cmbbType.SelectedIndex = -1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exiting the program
            Close();
        }
    }
}