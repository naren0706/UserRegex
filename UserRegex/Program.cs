using System.Threading.Channels;

namespace UserRegex
{
    class Program
    {
        public static void Main(string[] args)
        {
            User user = new User()
            {
                firstName = Console.ReadLine()
            };
            user.ValidateFirstName();
        }
    }
}