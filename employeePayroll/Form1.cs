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
        SalariedEmployee newSalariedEmployee;



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