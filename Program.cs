using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Regex Program");

            Password validate = new Password();

            Console.Write("Enter Your password : ");

            string password = Console.ReadLine();

            bool val = validate.ValidatePassword(password);

            if (val)
            {
                Console.WriteLine("password is Valid");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }


    }
    }
    
