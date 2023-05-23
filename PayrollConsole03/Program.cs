using System;
using static System.Console;

namespace PayrollConsole03
{
    internal class Program
    {
        //  Declare and initialize program constants
        const decimal MINHOURS =  0M;       //  Minimum hours to work
        const decimal MAXHOURS = 84M;       //  Maximum hours to work
        const decimal MINRATE  =  0M;       //  Minimum hourly rate
        const decimal MAXRATE  = 99.99M;    //  Maximum hourly rate
        const decimal MAXNONOT = 40M;       //  Max hour to work without OT
        const decimal OTRATE   =  1.5M;     //  Overtime rate
        static void Main(string[] args)
        {
            bool keepGoing = true;

            while (keepGoing)
            {
                string  fname = InputFirstName();
                string  lname = InputLastName();
                decimal hours = InputHours();
                decimal rate  = InputRate();
                decimal gross = CalculateGrossPay(hours, rate);
                keepGoing = DisplayAllInputsAndOutputs(fname, lname, hours, rate, gross);

                ReadLine();
            }
        }

        static string InputFirstName()
        {
            bool keepGoing = true;
            string first   = "";

            while (keepGoing)
            {
                Write("\nPlease enter your first name: ");
                first = ReadLine();

                if (first.Trim() != "")
                {
                    keepGoing = false;
                }
            }

            return first;
        }

        static string InputLastName()
        {
            bool keepGoing = true;
            string last    = "";

            while (keepGoing)
            {
                Write("\nPlease enter your last name: ");
                last = ReadLine();

                if (last.Trim() != "")
                {
                    keepGoing = false;
                }
            }

            return last;
        }

        static decimal InputHours()
        {
            bool keepGoing = true;
            bool result;
            decimal hours  = 0.0M;

            while (keepGoing)
            {
                Write("\nPlease enter hours worked (0 - 84): ");
                result = Decimal.TryParse(ReadLine(), out hours);

                if ((!result) ||((hours < MINHOURS) || (hours > MAXHOURS)))
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }
            }

            return hours;
        }

        static decimal InputRate()
        {
            bool keepGoing = true;
            bool result;
            decimal rate = 0.0M;

            while (keepGoing)
            {
                Write("\nPlease enter hourly rate (0 - 99.99): ");
                result = Decimal.TryParse(ReadLine(), out rate);

                if ((!result) || ((rate < MINRATE) || (rate > MAXRATE)))
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                }
            }

            return rate;
        }

        static decimal CalculateGrossPay(decimal hours, decimal rate)
        {
            decimal gross  = 0M;
            decimal regHrs = 40M;
            decimal otHrs  = 0M;
            decimal regPay = 0M;
            decimal otPay  = 0M;

            if (hours <= MAXNONOT)              //  40 or < hours worked. No overtime
            {
                gross = hours * rate;
            }
            else
            {                                   //  > 40 hours worked. Pay overtime
                regPay = regHrs * rate;         //  Regular pay, first 40 hours no OT paid.
                otHrs  = hours - regHrs;        //  # of Overtime hours worked
                otPay  = otHrs * rate * OTRATE; //  OT pay, ot hours * rate * 1.5
                gross  = regPay + otPay;
            }

            return gross;
        }

        static bool DisplayAllInputsAndOutputs(string fn, string ln, 
                                               decimal h, decimal r, decimal g)
        {
            Clear();
            WriteLine("Name:  " + fn + " " + ln);
            WriteLine("Hours: " + h.ToString("n2"));
            WriteLine("Rate:  " + r.ToString("c"));
            WriteLine("Gross: " + g.ToString("c"));

            Write("\n\nRun the program again (Y/N): ");
            string again = ReadLine();
            bool yesOrNo = false;

            if (again.ToUpper() == "Y")
            {
                yesOrNo = true;
            }

            return yesOrNo;
        }
    }
}
