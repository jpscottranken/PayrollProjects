using static System.Console;

namespace PayrollConsole01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Declare and initialize program variables
            string firstName = "Jeff";          //  first name
            string lastName  = "Scott";         //  last  name
            string outputStr = "";              //  output string
            decimal hours    = 40.00M;          //  hours worked
            decimal rate     = 25.00M;          //  hourly rate
            decimal gross    = hours * rate;    //  hours worked * hourly rate

            //  Build output string
            outputStr += "PAYROLL CALCULATOR\n";
            outputStr += "NAME:\t"     + firstName + " " + lastName;
            outputStr += "\nHOURS:\t"  + hours.ToString("n2");
            outputStr += "\nRATE:\t"   + rate.ToString("c");
            outputStr += "\nGROSS:\t"  + gross.ToString("c");

            //  Display output string
            WriteLine(outputStr);

            ReadLine();
        }
    }
}
