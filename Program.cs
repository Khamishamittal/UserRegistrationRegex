using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Regex Program");

            ValidPhoneNumber mobileNumber = new ValidPhoneNumber();

            Console.Write("Enter Your mobileNumber : ");

            string number = Console.ReadLine();

            bool val = mobileNumber.ValidateMobileNumber(number);

            if (val)
            {
                Console.WriteLine("mobileNumber is Valid");
            }
            else
            {
                Console.WriteLine("Invalid mobileNumber");
            }
        }


    }
    }
    
