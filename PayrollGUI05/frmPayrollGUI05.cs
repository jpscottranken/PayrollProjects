using System;
using System.Windows.Forms;

namespace PayrollGUI05
{
    public partial class frmPayrollGUI05 : Form
    {
        public frmPayrollGUI05()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINHOURSWORKED =  0m;         //  Minimum hours worked
        const decimal MAXHOURSWORKED = 84m;         //  Maxnimum hours worked
        const decimal MINHOURLYRATE  =  0m;         //  Minimum hourly rate
        const decimal MAXHOURLYRATE  = 99.99m;      //  Maximum hourly rate
        const decimal MAXNONOT       = 40M;         //  Max # hours worked no OT
        const decimal OTRATE         =  1.5M;       //  Overtime rate
        const string  DATEOPENED     = "01/01/2000";//  Date the company opened
        DateTime startDate           = DateTime.Parse(DATEOPENED);
        DateTime hDate;                             //  Date employee hired
        DateTime currentDate         = DateTime.Today;// Current Date
        decimal grossPay             =  0M;         //  Gross pay
        decimal totalNumGrossPays    =  0M;         //  Total # Gross Pays
        decimal totalGrossPayAmt     =  0m;         //  Total Gross Pay Amount
        decimal avgGrossPayAmt       =  0m;         //  Average Gross Pay Amount

        //  Global arrays
        int[] empIDs =            {
                                    1000, 1001, 1002, 1003, 1004,
                                    1005, 1006, 1007, 1008, 1009
                                  };
        string[] empDepartments = {
                                    "Web Programming", "Accounting",
                                    "Shipping", "Receiving", "Auditing",
                                    "Auditing", "Receiving", "Shipping",
                                    "Accounting", "Web Programming"
                                  };
        string[] empFirstNames =  {
                                    "Ben", "Mary", "William", "Gail", "Ron",
                                    "Gwen", "Sally", "Mark", "Mike", "Sandy"
                                  };

        string[] empLastNames =   {
                                    "Jones", "Smith", "Doe", "Brown", "White",
                                    "Green", "Black", "King", "Johns", "Cason"
                                  };

        DateTime[] empHireDates = {
                                    new DateTime(2000, 10,  1, 0, 0, 0),
                                    new DateTime(2001, 1,   3, 0, 0, 0),
                                    new DateTime(2002, 8,   6, 0, 0, 0),
                                    new DateTime(2003, 11, 21, 0, 0, 0),
                                    new DateTime(2004, 3,   3, 0, 0, 0),
                                    new DateTime(2005, 6,  13, 0, 0, 0),
                                    new DateTime(2006, 12, 12, 0, 0, 0),
                                    new DateTime(2007, 11, 11, 0, 0, 0),
                                    new DateTime(2008, 4,  14, 0, 0, 0),
                                    new DateTime(2009, 9,  19, 0, 0, 0)
                                 };

        decimal[] empHoursWorked =  {
                                      40M, 37.5M, 55M, 60M, 25M,
                                      35M, 44.5M, 56M, 73M, 12M
                                  };

        decimal[] empHourlyRate = {
                                      10M, 12.5M, 15M, 20M, 25M,
                                      35M, 44.5M, 22M, 25M, 19.5M
                                  };

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateGrossPay();
            UpdateAccumulators();
            btnCalculate.Enabled = false;
        }

        private bool IsValidData()
        {
            string errorMessage = "";

            // Validate the employee ID text box
            errorMessage += IsPresent(txtEmployeeID.Text, "employeeID", txtEmployeeID);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the employee ID text box
            errorMessage += IsPresent(txtEmployeeID.Text, "employeeID", txtEmployeeID);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            return true;
        }

        private string IsPresent(string value, string name, Control ctrl)
        {
            string msg = "";
            if (value.Trim() == "")
            {
                msg = name + " is a required field.\n";
                ClearAndFocusCorrectControl(ctrl);
            }

            return msg;
        }
        private void ClearAndFocusCorrectControl(Control ctrl)
        {
            ctrl.Text = "";
            ctrl.Focus();
        }

        private void CalculateGrossPay()
        {
            decimal regHrs = 40M;
            decimal otHrs = 0M;
            decimal regPay = 0M;
            decimal otPay = 0M;
            decimal hours = Convert.ToDecimal(txtHoursWorked.Text);
            decimal rate = Convert.ToDecimal(txtHourlyRate.Text);

            if (hours <= MAXNONOT)              //  40 or < hours worked. No overtime
            {
                grossPay = hours * rate;
            }
            else
            {                                   //  > 40 hours worked. Pay overtime
                regPay = regHrs * rate;         //  Regular pay, first 40 hours no OT paid.
                otHrs = hours - regHrs;         //  # of Overtime hours worked
                otPay = otHrs * rate * OTRATE;  //  OT pay, ot hours * rate * 1.5
                grossPay = regPay + otPay;
            }

            txtGrossPay.Text     = grossPay.ToString("c");
            btnCalculate.Enabled = false;
        }

        private void UpdateAccumulators()
        {
            //  Increment total number of gross pays calculated
            totalNumGrossPays++;
            txtTotalGrossPays.Text = totalNumGrossPays.ToString();

            //  Calculate and display total gross pay amount
            totalGrossPayAmt += grossPay;
            txtTotalGrossPayAmt.Text = totalGrossPayAmt.ToString("c");

            //  Calculate and display average gross pay amount
            avgGrossPayAmt = totalGrossPayAmt / totalNumGrossPays;
            txtAvgGrossPayAmt.Text = avgGrossPayAmt.ToString("c");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtEmployeeID.Text      = "";
            txtDepartment.Text      = "";
            txtFirstName.Text       = "";
            txtLastName.Text        = "";
            txtHireDate.Text        = "";
            txtYearsOfService.Text  = "";
            txtHoursWorked.Text     = "";
            txtHourlyRate.Text      = "";
            txtGrossPay.Text        = "";
            btnCalculate.Enabled    = false;
            txtEmployeeID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            AttemptToLookupEmployeeByID();
        }

        private void AttemptToLookupEmployeeByID()
        {
            string errMessage = "";
            int    id;

            btnCalculate.Enabled = false;

            //  Check for nothing entered into EmployeeID textbox
            errMessage = IsPresent(txtEmployeeID.Text, "employeeID", txtEmployeeID);

            //  Verify that something was entered into
            //  the EmployeeID textbox
            if (errMessage != "")
            {                           //  Nothing was entered
                ShowMessage(errMessage, "NO EMPLOYEE ID GIVEN");
                return;
            }

            //  Something was entered into the EmployeeID textbox
            id = Int32.Parse(txtEmployeeID.Text);

            switch (id)
            {
                case 1000:
                    FillTextBoxes(0);
                    break;

                case 1001:
                    FillTextBoxes(1);
                    break;

                case 1002:
                    FillTextBoxes(2);
                    break;

                case 1003:
                    FillTextBoxes(3);
                    break;

                case 1004:
                    FillTextBoxes(4);
                    break;

                case 1005:
                    FillTextBoxes(5);
                    break;

                case 1006:
                    FillTextBoxes(6);
                    break;

                case 1007:
                    FillTextBoxes(7);
                    break;

                case 1008:
                    FillTextBoxes(8);
                    break;

                case 1009:
                    FillTextBoxes(9);
                    break;

                default:
                    ShowMessage("Employee ID: " + id + " Not Found",
                                "NO EMPLOYEE WITH ID INPUTTED");
                    txtEmployeeID.Text = "";
                    txtEmployeeID.Focus();
                    break;
            }

            btnCalculate.Enabled = true;
        }

        private void FillTextBoxes(int emp)
        {
            string dateOnlyString = empHireDates[emp].ToString("MM/dd/yyyy");
            txtDepartment.Text    = empDepartments[emp];
            txtFirstName.Text     = empFirstNames[emp];
            txtLastName.Text      = empLastNames[emp];
            txtHireDate.Text      = dateOnlyString;
            txtHoursWorked.Text   = empHoursWorked[emp].ToString("n2");
            txtHourlyRate.Text    = empHourlyRate[emp].ToString("n2");

            CalculateYearsOfService(empHireDates[emp]);
        }

        private void CalculateYearsOfService(DateTime hDate)
        {
            DateTime now = DateTime.Today;
            int tos = now.Year - hDate.Year;
            if (hDate > now.AddYears(-tos)) tos--;
            txtYearsOfService.Text = tos.ToString();
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void frmPayrollGUI05_Load(object sender, EventArgs e)
        {
            btnCalculate.Enabled = false;
        }
    }
}
