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
        Dictionary<string, List<Contact>> dictName = new Dictionary<string, List<Contact>>();
        Dictionary<string, string> cityPerson = new Dictionary<string, string>();
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
        public void Update()
        {
            foreach (var contact in addContact)
            {
                Console.WriteLine("Enter The Number First Name");
                string name = Convert.ToString(Console.ReadLine());

                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1.LastName\n2.Address\n3.City\n4.State\n5.Pin\n6.PhoneNumber\n7.Email ");
                    int optionn = Convert.ToInt32(Console.ReadLine());
                    switch (optionn)
                    {
                        case 1:
                            Console.WriteLine("enter the last name you want to edit : ");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("enter the address you want to edit :");
                            contact.Address = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("enter the city: ");
                            contact.City = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("enter the state you want to edit :");
                            contact.State = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("enter the email you want to edit :");
                            contact.Email = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("enter the zip you want to edit :");
                            contact.Zip = Convert.ToInt32(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("enter the phone you want to edit :");
                            contact.Mobile = Convert.ToInt64(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Choose the right option : ");
                            break;
                    }


                }
                else
                {
                    Console.WriteLine("Name not Exist");
                }
                Display();
            }
        }
        public void Delete()
        {
            Contact d = new Contact();
            Console.WriteLine("Enter First Name");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var contact in addContact)
            {
                if (contact.FirstName.Equals(name))
                {
                    d = contact;
                }
            }
            addContact.Remove(d);
            Display();

        }
        public void AddMultipleContacts()
        {
            Console.WriteLine("Enter the number of contacts to be added: ");
            int numberOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numberOfContacts > 0)
            {
                AddContact();
                numberOfContacts--;
            }
        }
        public void Adduniquecontacts()
        {
            Console.WriteLine("Enter the Firstname in your contactlist");
            string name = Console.ReadLine();
            foreach (var data in addContact)
            {
                if (addContact.Contains(data))
                {
                    if (data.FirstName == name)
                    {
                        Console.WriteLine("This contact exists please enter an unique name to store this data");
                        string uniquename = Console.ReadLine();
                        if (dictName.ContainsKey(uniquename))
                        {
                            Console.WriteLine("This unique name already exists");
                        }
                        dictName.Add(uniquename, addContact);
                        return;
                    }
                }
            }
            Display();
        }
        public bool NameExists(string name)
        {
            foreach (var dictionary in dictName.Keys)
            {
                if (dictionary.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
        public void SearchingPersonInCity(string cityName)
        {
            foreach (var contact in addContact)
            {
                if (contact.City.Equals(cityName))
                {
                    Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Mobile);
                }

            }
        }
        public void MaintainDictionaryWithCityAndPerson(string cityName)
        {
            cityPerson.Add("Ajay", "Basti");
            cityPerson.Add("Vijay", "Basti");
            cityPerson.Add("Raj", "Lucknow");
            cityPerson.Add("Ritesh", "Allahabad");
            cityPerson.Add("Aman", "Basti");
            cityPerson.Add("Anuragh", "Banaras");
            foreach (var contact in cityPerson)
            {
                if (contact.Value.Equals(cityName))
                {
                    Console.WriteLine(contact.Key + " " + contact.Value);
                }
            }
        }
        public void GetNumberByCity(string cityName)
        {
            foreach (var contact in addContact)
            {
                if (contact.City.Equals(cityName))
                {
                    Console.WriteLine("Mobile Number is" + contact.Mobile);
                }
            }
        }
        public void SortPersonName()
        {
            var result = addContact.OrderBy(x => x.FirstName).ToList();
            foreach (var contact in result)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Mobile);

            }
        }
        public void SortCityorState()
        {
            var result = this.addContact.OrderBy(x => x.City).ToList();
            foreach (var contact in result)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName + " " + contact.Address + " " + contact.City + " " + contact.State + " " + contact.Email + " " + " " + contact.Zip + " " + contact.Mobile);

            }
        }
    }
}
