using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace UserRegex
{
    public class User
    {

        public bool ValidatePassword(string password)
        {
            string re = @"^(?=.*[\$\&\+\,\:\;\=\?\@\#\|\'\<\>\.\-\^\*\(\)\%\!])(?=.*[0-9])(?=.*[A-Z]).+.{8,}$";
            Regex regex = new Regex(re);
            return regex.IsMatch(password);
        }
        public bool ValidatePhonenumber(string phoneNumber)
        {
            string re = "^[0-9]{2}[ ]{1}[0-9]{10}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(phoneNumber))
            {
                return true;

            }
            else
            {
                return false;

            }
        }
        public bool ValidateLastName(string lastName)
        {
            string re = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(lastName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateFirstName(string firstName)
        {
            string re = "^[A-Z]{1}[a-z]{2,}$";
            Regex regex = new Regex(re);
            if (regex.IsMatch(firstName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ValidateEmail(string email)
        {
            string emailRegex = @"^[^.]([a-z0-9\-+]{0,})[\.]{0,1}([a-z0-9\-+]{1,})(@{1}[a-z0-9]{1,})(\.)([a-z]{0,}[\.]{0,1}[a-z]{2,})]{0,}$";
            Regex regex = new Regex(emailRegex);
            if (regex.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}