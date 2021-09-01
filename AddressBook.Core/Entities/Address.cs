using AddressBook.Core.Enumerations;
using AddressBook.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Core.Entities
{
    public class Address
    {
        public Address()
        {

        }

        public Address(string line1, string line2, string city, State state, string zipCode)
        {
            this.AddressLine1 = line1;
            this.AddressLine2 = line2;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public State State { get; set; }

        public string ZipCode { get; set; }

        public override string ToString()
        {
            return this.FormatForUI();
        }
    }
}
