using AddressBook.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Extensions
{
    public static class AddressExtensions
    {
        public static string FormatForUI(this Address source)
        {
            var addressLine2 = string.IsNullOrWhiteSpace(source.AddressLine2) ? default : $"\n{source.AddressLine2}";

            return $"{source.AddressLine1} {addressLine2}\n" +
                $"{source.City}, {source.State} {source.ZipCode}";
        }
    }
}
