using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Resources
{
    public static class RegularExpressions
    {
        public const string PhoneNumber = @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}";
        public const string ZipCode = @"^[0-9]{5}(?:-[0-9]{4})?$";
    }
}
