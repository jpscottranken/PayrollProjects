using System;
using System.Windows.Forms;

namespace PayrollGUI04
{
    public partial class frmPayrollGUI04 : Form
    {
        public frmPayrollGUI04()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINHOURSWORKED = 0m;          //  Minimum hours worked
        const decimal MAXHOURSWORKED = 84m;         //  Maxnimum hours worked
        const decimal MINHOURLYRATE  = 0m;          //  Minimum hourly rate
        const decimal MAXHOURLYRATE  = 99.99m;      //  Maximum hourly rate
        const decimal MAXNONOT       = 40M;         //  Max # hours worked no OT
        const decimal OTRATE         = 1.5M;        //  Overtime rate
        decimal grossPay             = 0M;          //  Gross pay
        decimal totalNumGrossPays    = 0M;          //  Total # Gross Pays
        decimal totalGrossPayAmt     = 0m;          //  Total Gross Pay Amount
        decimal avgGrossPayAmt       = 0m;          //  Average Gross Pay Amount

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal hours  = 0m;
            decimal rate   = 0m;
            string  msg    = "";

            try
            {
                if (IsValidData())
                {
                    hours = Convert.ToDecimal(txtHoursWorked.Text);
                    rate  = Convert.ToDecimal(txtHourlyRate.Text);

                    CalculateGrossPay();
                    UpdateAccumulators();
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"{msg}\n{ex.Message}\n\n",
                            "ERROR MESSAGES");
            }
        }

        private bool IsValidData()
        {
            string errorMessage = "";

            // Validate the firstname text box
            errorMessage += IsPresent(txtFirstName.Text, "first name", txtFirstName);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the lastname text box
            errorMessage += IsPresent(txtLastName.Text, "last name", txtLastName);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the hoursWorked text box
            errorMessage += IsPresent(txtHoursWorked.Text, "hours worked", txtHoursWorked);
            errorMessage += IsDecimal(txtHoursWorked.Text, "hours worked", txtHoursWorked);
            errorMessage += IsWithinRange(txtHoursWorked.Text, "hours worked", 
                                          MINHOURSWORKED, MAXHOURSWORKED, txtHoursWorked);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the gallons used text box
            errorMessage += IsPresent(txtHourlyRate.Text, "hourly rate", txtHourlyRate);
            errorMessage += IsDecimal(txtHourlyRate.Text, "hourly rate", txtHourlyRate);
            errorMessage += IsWithinRange(txtHourlyRate.Text, "hourly rate", 
                                            MINHOURLYRATE, MAXHOURLYRATE, txtHourlyRate);

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
            if (value == "")
            {
                msg = name + " is a required field.\n";
                ClearAndFocusCorrectControl(ctrl);
            }

            return msg;
        }

        private string IsDecimal(string value, string name, Control ctrl)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg = name + " must be a valid decimal value.\n";
                ClearAndFocusCorrectControl(ctrl);
            }

            return msg;
        }

        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value.\n";
            }
            return msg;
        }

        private string IsWithinRange(string value, string name, decimal min, decimal max, Control ctrl)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                    ClearAndFocusCorrectControl(ctrl);
                }
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

            txtGrossPay.Text = grossPay.ToString("c");
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
            txtFirstName.Text   = "";
            txtLastName.Text    = "";
            txtHoursWorked.Text = "";
            txtHourlyRate.Text  = "";
            txtGrossPay.Text    = "";
            txtFirstName.Focus();
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

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);

        }
    }
}
