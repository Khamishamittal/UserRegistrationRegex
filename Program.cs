namespace UserRegistrationRegex
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to User Registration Regex Program");


            ValidLastName lastName = new ValidLastName();

            Console.Write("Enter Your Last Name : ");

            string LastName = Console.ReadLine();

            bool val = lastName.ValidateFirstName(LastName);

            if (val)
            {
                Console.WriteLine("LastName is Valid");
            }
            else
            {
                Console.WriteLine("Invalid LastName");
            }
        }
        }
    }
    
