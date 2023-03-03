using System.Text.RegularExpressions;
using static UserRegistrationRegex.NumericPassword;

namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            ClearEmailSamples validate = new ClearEmailSamples();


            validate.ClearEmail();
        }
    }
}






    
