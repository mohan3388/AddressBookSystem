using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProblem
{
    public class AddressBook
    {

List<Contact> cont=new List<Contact> ();


        public void Address()

        {

            Contact contact = new Contact();
            {
                contact.FirstName = "mohan";
                contact.LastName = "sahu";
                contact.Address = "green valey";
                contact.City = "bhilai";
                contact.State = "cg";
                contact.Email = "sahu@12gmail.com";
                contact.Zip = 12451;
                contact.Mobile = 744551552;

            }
            cont.Add(contact);
        }
       

            
        
        public void Display()

        {
            //Console.WriteLine(cont.FirstName);            

            foreach (var con in cont)
            {
                Console.WriteLine(con.FirstName + " " + con.LastName + " " + con.Address + " " + con.City + " " + con.State + " " + con.Email + " " + con.Zip + " " + con.Mobile);
            }
        }
    }
}
