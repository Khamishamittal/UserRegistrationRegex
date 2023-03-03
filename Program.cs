using System.Text.RegularExpressions;
using static UserRegistrationRegex.NumericPassword;

namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the User Registration Problems using Regular Expression");

            PasswordSpecialCharacter validate = new PasswordSpecialCharacter();

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





    
