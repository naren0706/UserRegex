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
        public string password { get; set; }

        public void ValidatePassword()
        {
            string re = @"^(?=.*[\$\&\+\,\:\;\=\?\@\#\|\'\<\>\.\-\^\*\(\)\%\!])(?=.*[0-9])(?=.*[A-Z]).+.{8,}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(this.password))
                Console.WriteLine("password is valid");
            else
                Console.WriteLine("password not valid");
        }
        public void ValidatePhonenumber()
        {
            string re = "^[0-9]{2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(this.PhoneNumber))
                Console.WriteLine("phone Number is valid");
            else
                Console.WriteLine("phone Number not valid");
        }
        public void ValidateLastName()
        {
            string re = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(this.lastName))
                Console.WriteLine("Last name is valid");
            else
                Console.WriteLine("Last Name not valid");
        }
        public void ValidateFirstName()
        {
            string re = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(this.firstName))
                Console.WriteLine("First name is valid");
            else
                Console.WriteLine("First Name not valid");
        }
        public void ValidateEmail()
        {
            string re = @"^[^.]([a-z0-9\-+]{0,})[\.]{0,1}([a-z0-9\-+]{1,})(@{1}[a-z0-9]{1,})(\.)([a-z]{0,}[\.]{0,1}[a-z]{2,})]{0,}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(this.email))
                Console.WriteLine(this.email + " is Valid email");
            else
                Console.WriteLine(this.email + " is not valid email");
        }
    }
}