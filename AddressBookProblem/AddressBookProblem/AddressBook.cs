using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {
        List<Contact> addContact = new List<Contact>();
        public void AddContact()
        {

            Console.WriteLine("Enter the Address Details");

            Contact contact1 = new Contact()
            {
                FirstName = Convert.ToString(Console.ReadLine()),

                LastName = Convert.ToString(Console.ReadLine()),

                Address = Convert.ToString(Console.ReadLine()),

                City = Convert.ToString(Console.ReadLine()),

                State = Convert.ToString(Console.ReadLine()),

                Zip = Convert.ToInt32(Console.ReadLine()),

                Mobile = Convert.ToInt64(Console.ReadLine()),

                Email = Convert.ToString(Console.ReadLine()),

            };
            Contact contact2 = new Contact()
            {
                FirstName = "Mohan",

                LastName = "Sahu",

                Address = "Bhilai",

                City = "Bhilai",

                State = "CG",

                Zip = 490020,

                Mobile = 82828883837,

                Email = "mohan@com",

            };

            Contact contact3 = new Contact()
            {
                FirstName = "Govind",

                LastName = "Bhatt",

                Address = "Bhilai",

                City = "Bhilai",

                State = "CG",

                Zip = 490021,

                Mobile = 82828883837,

                Email = "govind@gmail.com",

            };
            addContact.Add(contact1);
            addContact.Add(contact2);
            addContact.Add(contact3);
        }
        public void Display()
        {
            foreach (var contact in addContact)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Zip + " " + contact.Mobile + " " + contact.Email);
            }
        }
    }
}
