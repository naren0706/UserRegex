using System.Threading.Channels;

namespace UserRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First name Last name");
            User user = new User()
            {
                firstName = Console.ReadLine(),
                lastName = Console.ReadLine()
            };
            user.ValidateFirstName();
            user.ValidateLastName();
        }
    }
}