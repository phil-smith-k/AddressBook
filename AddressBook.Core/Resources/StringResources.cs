using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Resources
{
    public static class StringResources
    {
        public const string EnterFirstName = "Enter First Name:";
        public const string EnterLastName = "Enter Last Name:";
        public const string EnterPhoneNumber = "Enter Phone Number:";
        public const string EnterEmailAddress = "Enter Email Address";
        public const string EnterAddressLine1 = "Enter Address Line 1:";
        public const string EnterAddressLine2 = "Enter Address Line 2: (if none, press enter)";
        public const string EnterCity = "Enter City:";
        public const string EnterState = "Enter State:";
        public const string EnterZipCode = "Enter Zip Code";

        public const string ErrorMessageForState = "Not a valid US State. Please try again.";
        public const string ErrorMessageForPhoneNumber = "Not a valid phone number. Please try again.";
        public const string ErrorMessageForEmailAddress = "Not a valid email address. Please try again.";
        public const string ErrorMessageForZipCode = "Not a valid US Zip Code. Please try again.";
        public const string ErrorMessageForIsRequired = "This field is required";

        public const string InvalidMenuChoice = "Not a valid option. Please try again.";

        public const string ContactDashes = "-------------------------";
    }
}
