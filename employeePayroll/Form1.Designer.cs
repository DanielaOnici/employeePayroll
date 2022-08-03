namespace employeePayroll
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbSSN = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblSocialSecurityNumber = new System.Windows.Forms.Label();
            this.gpbPayroll = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblErrorMessageFour = new System.Windows.Forms.Label();
            this.lblErrorMessageThree = new System.Windows.Forms.Label();
            this.lblErrorMessageTwo = new System.Windows.Forms.Label();
            this.lblErrorMessageOne = new System.Windows.Forms.Label();
            this.lblGrossSales = new System.Windows.Forms.Label();
            this.lblComissionRate = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblBaseSalary = new System.Windows.Forms.Label();
            this.txtbGrossSales = new System.Windows.Forms.TextBox();
            this.txtbComissionRate = new System.Windows.Forms.TextBox();
            this.txtbHours = new System.Windows.Forms.TextBox();
            this.txtbWage = new System.Windows.Forms.TextBox();
            this.txtbBaseSalary = new System.Windows.Forms.TextBox();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.cmbbType = new System.Windows.Forms.ComboBox();
            this.gpbPayroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(189, 26);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(185, 23);
            this.txtbFirstName.TabIndex = 0;
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(189, 55);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(185, 23);
            this.txtbLastName.TabIndex = 1;
            // 
            // txtbSSN
            // 
            this.txtbSSN.Location = new System.Drawing.Point(189, 84);
            this.txtbSSN.Name = "txtbSSN";
            this.txtbSSN.Size = new System.Drawing.Size(185, 23);
            this.txtbSSN.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(113, 30);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name: ";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(113, 58);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblSocialSecurityNumber
            // 
            this.lblSocialSecurityNumber.AutoSize = true;
            this.lblSocialSecurityNumber.Location = new System.Drawing.Point(15, 87);
            this.lblSocialSecurityNumber.Name = "lblSocialSecurityNumber";
            this.lblSocialSecurityNumber.Size = new System.Drawing.Size(168, 15);
            this.lblSocialSecurityNumber.TabIndex = 5;
            this.lblSocialSecurityNumber.Text = "Social Security Number (SSN): ";
            // 
            // gpbPayroll
            // 
            this.gpbPayroll.Controls.Add(this.lblResult);
            this.gpbPayroll.Controls.Add(this.btnCalculate);
            this.gpbPayroll.Controls.Add(this.lblErrorMessageFour);
            this.gpbPayroll.Controls.Add(this.lblErrorMessageThree);
            this.gpbPayroll.Controls.Add(this.lblErrorMessageTwo);
            this.gpbPayroll.Controls.Add(this.lblErrorMessageOne);
            this.gpbPayroll.Controls.Add(this.lblGrossSales);
            this.gpbPayroll.Controls.Add(this.lblComissionRate);
            this.gpbPayroll.Controls.Add(this.lblHours);
            this.gpbPayroll.Controls.Add(this.lblWage);
            this.gpbPayroll.Controls.Add(this.lblBaseSalary);
            this.gpbPayroll.Controls.Add(this.txtbGrossSales);
            this.gpbPayroll.Controls.Add(this.txtbComissionRate);
            this.gpbPayroll.Controls.Add(this.txtbHours);
            this.gpbPayroll.Controls.Add(this.txtbWage);
            this.gpbPayroll.Controls.Add(this.txtbBaseSalary);
            this.gpbPayroll.Controls.Add(this.lblEmployeeType);
            this.gpbPayroll.Controls.Add(this.cmbbType);
            this.gpbPayroll.Controls.Add(this.lblSocialSecurityNumber);
            this.gpbPayroll.Controls.Add(this.lblLastName);
            this.gpbPayroll.Controls.Add(this.lblFirstName);
            this.gpbPayroll.Controls.Add(this.txtbSSN);
            this.gpbPayroll.Controls.Add(this.txtbLastName);
            this.gpbPayroll.Controls.Add(this.txtbFirstName);
            this.gpbPayroll.Location = new System.Drawing.Point(10, 7);
            this.gpbPayroll.Name = "gpbPayroll";
            this.gpbPayroll.Size = new System.Drawing.Size(773, 332);
            this.gpbPayroll.TabIndex = 6;
            this.gpbPayroll.TabStop = false;
            this.gpbPayroll.Text = "Payroll System";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(407, 171);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 30;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(189, 287);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(185, 23);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblErrorMessageFour
            // 
            this.lblErrorMessageFour.AutoSize = true;
            this.lblErrorMessageFour.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessageFour.Location = new System.Drawing.Point(407, 81);
            this.lblErrorMessageFour.Name = "lblErrorMessageFour";
            this.lblErrorMessageFour.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageFour.TabIndex = 25;
            // 
            // lblErrorMessageThree
            // 
            this.lblErrorMessageThree.AutoSize = true;
            this.lblErrorMessageThree.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessageThree.Location = new System.Drawing.Point(407, 66);
            this.lblErrorMessageThree.Name = "lblErrorMessageThree";
            this.lblErrorMessageThree.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageThree.TabIndex = 24;
            // 
            // lblErrorMessageTwo
            // 
            this.lblErrorMessageTwo.AutoSize = true;
            this.lblErrorMessageTwo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessageTwo.Location = new System.Drawing.Point(407, 51);
            this.lblErrorMessageTwo.Name = "lblErrorMessageTwo";
            this.lblErrorMessageTwo.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageTwo.TabIndex = 23;
            // 
            // lblErrorMessageOne
            // 
            this.lblErrorMessageOne.AutoSize = true;
            this.lblErrorMessageOne.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessageOne.Location = new System.Drawing.Point(407, 36);
            this.lblErrorMessageOne.Name = "lblErrorMessageOne";
            this.lblErrorMessageOne.Size = new System.Drawing.Size(0, 15);
            this.lblErrorMessageOne.TabIndex = 22;
            // 
            // lblGrossSales
            // 
            this.lblGrossSales.AutoSize = true;
            this.lblGrossSales.Location = new System.Drawing.Point(111, 261);
            this.lblGrossSales.Name = "lblGrossSales";
            this.lblGrossSales.Size = new System.Drawing.Size(68, 15);
            this.lblGrossSales.TabIndex = 21;
            this.lblGrossSales.Text = "Gross Sales:";
            // 
            // lblComissionRate
            // 
            this.lblComissionRate.AutoSize = true;
            this.lblComissionRate.Location = new System.Drawing.Point(87, 232);
            this.lblComissionRate.Name = "lblComissionRate";
            this.lblComissionRate.Size = new System.Drawing.Size(92, 15);
            this.lblComissionRate.TabIndex = 20;
            this.lblComissionRate.Text = "Comission Rate:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(137, 203);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(42, 15);
            this.lblHours.TabIndex = 19;
            this.lblHours.Text = "Hours:";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Location = new System.Drawing.Point(139, 174);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(40, 15);
            this.lblWage.TabIndex = 18;
            this.lblWage.Text = "Wage:";
            // 
            // lblBaseSalary
            // 
            this.lblBaseSalary.AutoSize = true;
            this.lblBaseSalary.Location = new System.Drawing.Point(111, 145);
            this.lblBaseSalary.Name = "lblBaseSalary";
            this.lblBaseSalary.Size = new System.Drawing.Size(68, 15);
            this.lblBaseSalary.TabIndex = 17;
            this.lblBaseSalary.Text = "Base Salary:";
            // 
            // txtbGrossSales
            // 
            this.txtbGrossSales.Location = new System.Drawing.Point(189, 258);
            this.txtbGrossSales.Name = "txtbGrossSales";
            this.txtbGrossSales.Size = new System.Drawing.Size(185, 23);
            this.txtbGrossSales.TabIndex = 15;
            // 
            // txtbComissionRate
            // 
            this.txtbComissionRate.Location = new System.Drawing.Point(189, 229);
            this.txtbComissionRate.Name = "txtbComissionRate";
            this.txtbComissionRate.Size = new System.Drawing.Size(185, 23);
            this.txtbComissionRate.TabIndex = 14;
            // 
            // txtbHours
            // 
            this.txtbHours.Location = new System.Drawing.Point(189, 200);
            this.txtbHours.Name = "txtbHours";
            this.txtbHours.Size = new System.Drawing.Size(185, 23);
            this.txtbHours.TabIndex = 13;
            // 
            // txtbWage
            // 
            this.txtbWage.Location = new System.Drawing.Point(189, 171);
            this.txtbWage.Name = "txtbWage";
            this.txtbWage.Size = new System.Drawing.Size(185, 23);
            this.txtbWage.TabIndex = 12;
            // 
            // txtbBaseSalary
            // 
            this.txtbBaseSalary.Location = new System.Drawing.Point(189, 142);
            this.txtbBaseSalary.Name = "txtbBaseSalary";
            this.txtbBaseSalary.Size = new System.Drawing.Size(185, 23);
            this.txtbBaseSalary.TabIndex = 11;
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Location = new System.Drawing.Point(90, 116);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(89, 15);
            this.lblEmployeeType.TabIndex = 10;
            this.lblEmployeeType.Text = "Employee Type:";
            // 
            // cmbbType
            // 
            this.cmbbType.FormattingEnabled = true;
            this.cmbbType.Items.AddRange(new object[] {
            "Salaried",
            "Comission",
            "Hourly",
            "Base Plus Commission"});
            this.cmbbType.Location = new System.Drawing.Point(189, 113);
            this.cmbbType.Name = "cmbbType";
            this.cmbbType.Size = new System.Drawing.Size(185, 23);
            this.cmbbType.TabIndex = 9;
            this.cmbbType.SelectedIndexChanged += new System.EventHandler(this.cmbbType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 351);
            this.Controls.Add(this.gpbPayroll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpbPayroll.ResumeLayout(false);
            this.gpbPayroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txtbFirstName;
        private TextBox txtbLastName;
        private TextBox txtbSSN;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblSocialSecurityNumber;
        private GroupBox gpbPayroll;
        private Label lblGrossSales;
        private Label lblComissionRate;
        private Label lblHours;
        private Label lblWage;
        private Label lblBaseSalary;
        private TextBox txtbGrossSales;
        private TextBox txtbComissionRate;
        private TextBox txtbHours;
        private TextBox txtbWage;
        private TextBox txtbBaseSalary;
        private Label lblEmployeeType;
        private ComboBox cmbbType;
        private Label lblResult;
        private Button btnCalculate;
        private Label lblErrorMessageFour;
        private Label lblErrorMessageThree;
        private Label lblErrorMessageTwo;
        private Label lblErrorMessageOne;
    }
}