using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> addressBook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addressBook.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return addressBook[email];
        }
    }
}