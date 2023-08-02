using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegex
{
    internal class User
    {
        public string firstName { get; set; }

        public void ValidateFirstName()
        {
            string fnameRegex = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(fnameRegex);
            if (regex.IsMatch(this.firstName))
                Console.WriteLine("First name is valid");
            else
                Console.WriteLine("First Name not valid");
        }
    }
}