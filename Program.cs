namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Regex Program");


            ValidEmail email = new ValidEmail();

            Console.Write("Enter Your Email : ");

            string Email = Console.ReadLine();

            bool val = email.ValidateEmail(Email);

            if (val)
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
    }
    
