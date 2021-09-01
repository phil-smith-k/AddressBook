using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook.Core.Resources
{
    public static class StringValidation
    {
        public static string ValidateEmailAddress(string source)
        {
            if (!Regex.IsMatch(source, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new FormatException("Not a valid email address.");
            }
            return source;
        }

        public static string ValidateNullOrEmpty(string source)
        {
            if (string.IsNullOrWhiteSpace(source))
            {
                throw new FormatException("Field is required");
            }

            return source;
        }

        public static string ValidatePhoneNumber(string source)
        {
            if (!Regex.IsMatch(source, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}"))
            {
                throw new FormatException("Not a valid phone number");
            }

            return source;
        }

        public static string ValidateZipCode(string source)
        {
            if(!Regex.IsMatch(source, @"^[0-9]{5}(?:-[0-9]{4})?$"))
            {
                throw new FormatException("Not a valid US Zip Code");
            }

            return source;
        }
    }
}
