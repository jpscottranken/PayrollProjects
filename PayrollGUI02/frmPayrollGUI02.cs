using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI02
{
    public partial class frmPayrollGUI02 : Form
    {
        public frmPayrollGUI02()
        {
            InitializeComponent();
        }

        //  Declare and initialize program constants
        const decimal MINHOURSWORKED =  0m;
        const decimal MAXHOURSWORKED = 84m;
        const decimal MINHOURLYRATE  =  0m;
        const decimal MAXHOURLYRATE  = 99.99m;
        decimal totalNumGrossPays    =  0;
        decimal totalGrossPayAmt     =  0m;
        decimal avgGrossPayAmt       =  0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool result;
            decimal hoursWorked;
            decimal hourlyRate;
            decimal grossPay;

            //  Validate first name is not empty
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("First Name Cannot Be Empty!!!",
                                "EMPTY FIRST NAME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtFirstName.Focus();
                return;
            }

            //  Validate last name is not empty
            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Last Name Cannot Be Empty!!!",
                                "EMPTY LAST NAME",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                txtLastName.Focus();
                return;
            }

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
                return;
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
                return;
            }

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
                return;
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
                return;
            }

            //  All inputted fields were valid
            //  Calculate and display gross pay
            grossPay = hoursWorked * hourlyRate;
            txtGrossPay.Text = grossPay.ToString("c");

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
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHoursWorked.Text = "";
            txtHourlyRate.Text = "";
            txtGrossPay.Text = "";
            txtFirstName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
    }
}
