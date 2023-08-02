using System.Threading.Channels;

namespace UserRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First name, Last name , email,phone number");
            User user = new User()
            {
                //firstName = Console.ReadLine(),
                //lastName = Console.ReadLine(),
                //email = Console.ReadLine(),
                //PhoneNumber = Console.ReadLine(),
                firstName = "",
                lastName = "",
                email = "",
                PhoneNumber = "",
                password = Console.ReadLine()
            };
            user.ValidatePassword();
            //user.ValidateFirstName();
            //user.ValidateLastName();
            //user.ValidateEmail();
            //user.ValidatePhonenumber();
        }
    }
}