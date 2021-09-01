using AddressBook.Core.Contracts;
using AddressBook.Core.Entities;
using AddressBook.Core.Enumerations;
using AddressBook.Core.Extensions;
using AddressBook.Core.Repositories;
using AddressBook.Core.Resources;
using System;
using System.Threading.Tasks;

namespace AddressBook.UI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IRepository<Contact> repository = new ContactRepository();

            Contact contact = PromptUserForContact();
            var entity = await repository.Create(contact);

            if (entity != default)
            {
                Logger.Log("Successfully saved.", ConsoleColor.Green);
                Console.WriteLine(entity);
            }
        }

        static Contact PromptUserForContact()
        {
            var firstName = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterFirstName, StringResources.ErrorMessageForIsRequired, StringValidation.ValidateNullOrEmpty);
            var lastName = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterLastName, StringResources.ErrorMessageForIsRequired, StringValidation.ValidateNullOrEmpty);
            var phoneNumber = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterPhoneNumber, StringResources.ErrorMessageForPhoneNumber, StringValidation.ValidatePhoneNumber);
            var emailAddress = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterEmailAddress, StringResources.ErrorMessageForEmailAddress, StringValidation.ValidateEmailAddress);
            var addressLine1 = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterAddressLine1, StringResources.ErrorMessageForIsRequired, StringValidation.ValidateNullOrEmpty);
            var addressLine2 = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterAddressLine2);
            var city = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterCity, StringResources.ErrorMessageForIsRequired, StringValidation.ValidateNullOrEmpty);
            var state = UserInterfaceUtilities.PromptUserValidateResponse<State>(StringResources.EnterState, StringResources.ErrorMessageForState, EnumExtensions.ParseEnum<State>);
            var zipCode = UserInterfaceUtilities.PromptUserValidateResponse<string>(StringResources.EnterZipCode, StringResources.ErrorMessageForZipCode, StringValidation.ValidateZipCode);

            var address = new Address(addressLine1, addressLine2, city, state, zipCode);
            return new Contact(firstName, lastName, phoneNumber, emailAddress, address);
        }
    }
}
