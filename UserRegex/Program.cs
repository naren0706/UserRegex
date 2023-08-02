using System.Threading.Channels;

namespace UserRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First name, Last name , email");
            User user = new User()
            {
                firstName = Console.ReadLine(),
                lastName = Console.ReadLine(),
                email= Console.ReadLine()
            };
            user.ValidateFirstName();
            user.ValidateLastName();
            user.ValidateEmail();
        }
    }
}