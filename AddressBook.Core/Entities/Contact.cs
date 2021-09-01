using AddressBook.Core.Extensions;
using AddressBook.Core.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AddressBook.Core.Entities
{
    public class Contact
    {
        public Contact()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public Contact(
            string firstName, 
            string lastName, 
            string phoneNumber, 
            string emailAddress,
            Address address)
        {
            this.Id = Guid.NewGuid().ToString();

            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;

            this.Address = address;
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public Address Address { get; set; }

        public override string ToString()
        {
            return this.FormatForUI();
        }
    }
}
