using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook.Core.Resources
{
    public static class StringFormatting
    {
        public static string FormatPhoneNumber(string source)
        {
            return Regex.Replace(source, @"^\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*(\d)\D*$", "($1$2$3) $4$5$6-$7$8$9$10");
        }
    }
}
