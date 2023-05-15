using static System.Console;

namespace PayrollConsole02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Declare and initialize program variables
            string firstName;       //  first name
            string lastName;        //  last  name
            string outputStr = "";  //  output string
            decimal hours;          //  hours worked
            decimal rate;           //  hourly rate
            decimal gross;          //  hours worked * hourly rate

            Write("Enter Your First Name: ");
            firstName = ReadLine();
            Write("Enter Your Last  Name: ");
            lastName = ReadLine();
            Write("Enter Your Hrs Worked: ");
            hours = decimal.Parse(ReadLine());
            Write("Enter Your Hrly  Rate: ");
            rate = decimal.Parse(ReadLine());

            gross = hours * rate;

            //  Build output string
            Clear();
            outputStr += "PAYROLL CALCULATOR2\n";
            outputStr += "NAME:\t"    + firstName + " " + lastName;
            outputStr += "\nHOURS:\t" + hours.ToString("n2");
            outputStr += "\nRATE:\t"  + rate.ToString("c");
            outputStr += "\nGROSS:\t" + gross.ToString("c");

            //  Display output string
            WriteLine(outputStr);

            ReadLine();
        }
    }
}
