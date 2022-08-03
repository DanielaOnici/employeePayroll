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
    }
}