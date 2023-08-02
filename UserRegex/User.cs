using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegex
{
    internal class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get;  set; }
        public string PhoneNumber { get; set; }

        public void ValidatePhonenumber()
        {
            string lnameRegex = "^[0-9]{2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(lnameRegex);
            if (regex.IsMatch(this.PhoneNumber))
                Console.WriteLine("phone Number is valid");
            else
                Console.WriteLine("phone Number not valid");
        }
        public void ValidateLastName()
        {
            string lnameRegex = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(lnameRegex);
            if (regex.IsMatch(this.lastName))
                Console.WriteLine("Last name is valid");
            else
                Console.WriteLine("Last Name not valid");
        }
        public void ValidateFirstName()
        {
            string fnameRegex = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(fnameRegex);
            if (regex.IsMatch(this.firstName))
                Console.WriteLine("First name is valid");
            else
                Console.WriteLine("First Name not valid");
        }
        public void ValidateEmail()
        {
            string actualRegex = @"^[^.]([a-z0-9\-+]{0,})[\.]{0,1}([a-z0-9\-+]{1,})(@{1}[a-z0-9]{1,})(\.)([a-z]{0,}[\.]{0,1}[a-z]{2,})]{0,}$";
            Regex re = new Regex(actualRegex);
            if (re.IsMatch(this.email))
                Console.WriteLine(this.email + " is Valid email");
            else
                Console.WriteLine(this.email + " is not valid email");
        }
    }
}