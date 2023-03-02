namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Regex Program");

            ValidFirstName firstname = new ValidFirstName();

            Console.Write("Enter Your First Name : ");

            string FirstName = Console.ReadLine();

            bool val = firstname.ValidateFirstName(FirstName);

            if (val)
            {
                Console.WriteLine("FirstName is Valid");
            }
            else
            {
                Console.WriteLine("Invalid FirstName");
            }
        }


    }
    }
