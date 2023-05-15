using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI01
{
    public partial class frmPayroll01 : Form
    {
        public frmPayroll01()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //  Declare and initialize program variables
            decimal hours = decimal.Parse(txtHoursWorked.Text);
            decimal rate  = decimal.Parse(txtHourlyRate.Text);
            decimal gross = hours * rate;

            txtGrossPay.Text = gross.ToString("C");
        }

        private void btnClear_Click(object sender, EventArgs e)
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
