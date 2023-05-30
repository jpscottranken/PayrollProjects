using System;
using System.Drawing;
using System.Windows.Forms;

namespace PayrollGUI03
{
    public partial class frmPayrollGUI03 : Form
    {
        public frmPayrollGUI03()
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
        decimal hoursWorked          = 0M;          //  Hours worked
        decimal hourlyRate           = 0M;          //  Hourly rate
        decimal grossPay             = 0M;          //  Gross pay
        decimal totalNumGrossPays    = 0M;          //  Total # Gross Pays
        decimal totalGrossPayAmt     = 0m;          //  Total Gross Pay Amount
        decimal avgGrossPayAmt       = 0m;          //  Average Gross Pay Amount

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
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

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void clearMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtFirstName.Text    = "";
            txtLastName.Text     = "";
            txtHoursWorked.Text  = "";
            txtHourlyRate.Text   = "";
            txtGrossPay.Text     = "";
            txtFirstName.Focus();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            ValidateAndCalculate();
        }

        private void calculateMenuItem_Click(object sender, EventArgs e)
        {
            ValidateAndCalculate();
        }

        private void ValidateAndCalculate()
        {
            bool keepGoing = ValidateFirstName();

            if (keepGoing)
            {
                keepGoing = ValidateLastName();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateHoursWorked();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = ValidateHourlyRate();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                CalculateGrossPay();
                UpdateAccumulators();
            }
            else
            {
                return;
            }
        }

        private bool ValidateFirstName()
        {
            bool retVal = true;

            //  Validate first name is not empty
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("First Name Cannot Be Empty!!!",
                                "EMPTY FIRST NAME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtFirstName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateLastName()
        {
            bool retVal = true;

            //  Validate last name is not empty
            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Last Name Cannot Be Empty!!!",
                                "EMPTY LAST NAME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtLastName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateHoursWorked()
        {
            bool result;
            bool retVal = true;
            //  Validate hours worked is not empty
            result = Decimal.TryParse(txtHoursWorked.Text, out hoursWorked);

            if (!result)
            {
                MessageBox.Show("Hours Worked Must Be Between 0 - 84!",
                                "INVALID HOURS WORKED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtHoursWorked.Text = "";
                txtHoursWorked.Focus();
                retVal = false;
            }
            //  Validate hours worked is within range (>= 0 and <= 84)
            else if ((hoursWorked < MINHOURSWORKED) ||
                     (hoursWorked > MAXHOURSWORKED))
            {
                MessageBox.Show("Hours Worked Must Be Between 0 - 84!",
                                "OUT OF RANGE HOURS WORKED",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtHoursWorked.Text = "";
                txtHoursWorked.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool ValidateHourlyRate()
        {
            bool result;
            bool retVal = true;

            //  Validate hourly rate is not empty
            result = Decimal.TryParse(txtHourlyRate.Text, out hourlyRate);

            if (!result)
            {
                MessageBox.Show("Hourly Rate Must Be Between 0 - 99.99!",
                                "INVALID HOURLY RATE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtHourlyRate.Text = "";
                txtHourlyRate.Focus();
                retVal = false;
            }
            //  Validate hourly rate is within range (>= 0 and <= 99.99)
            else if ((hourlyRate < MINHOURLYRATE) ||
                     (hourlyRate > MAXHOURLYRATE))
            {
                MessageBox.Show("Hourly Rate Must Be Between 0 - 99.99!",
                                "OUT OF RANGE HOURLY RATE",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtHourlyRate.Text = "";
                txtHourlyRate.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void CalculateGrossPay()
        {
            decimal regHrs = 40M;
            decimal otHrs  = 0M;
            decimal regPay = 0M;
            decimal otPay  = 0M;
            decimal hours  = Convert.ToDecimal(txtHoursWorked.Text);
            decimal rate   = Convert.ToDecimal(txtHourlyRate.Text);

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

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            //btnExit.BackColor = Color.White;
            //btnCalculate.BackColor = Color.White;
            //btnClear.BackColor = Color.White;
            //btnExit.ForeColor = Color.Black;
            //btnCalculate.ForeColor = Color.Black;
            //btnClear.ForeColor = Color.Black;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            //btnExit.BackColor = Color.Black;
            //btnCalculate.BackColor = Color.Black;
            //btnClear.BackColor = Color.Black;
            //btnExit.ForeColor = Color.White;
            //btnCalculate.ForeColor = Color.White;
            //btnClear.ForeColor = Color.White;
        }
    }
}
