using AddressBook.Core.Entities;
using AddressBook.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Extensions
{
    public static class ContactExtensions
    {
        public static string FormatForUI(this Contact contact)
        {
            var formattedPhoneNumber = StringFormatting.FormatPhoneNumber(contact.PhoneNumber);

            return $"{StringResources.ContactDashes}\n" +
                $"{contact.FirstName} {contact.LastName}\n" +
                $"{contact.Address}\n" +
                $"{formattedPhoneNumber}\n" +
                $"{StringResources.ContactDashes}";
        }
    }
}
