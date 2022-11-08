using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
namespace AddressBook
{
    public class AddressBookMain
    {
        List<Contact> address = new List<Contact>();
        Contact contact = new Contact();
        int i = 0;
        public void CreateContact()
        {
            Console.WriteLine("Enter the firstName");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the lastName");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter the City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter the State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter the Zip");
            contact.Zip = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the PhoneNumber");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter the Email ID");
            contact.Email = Console.ReadLine();
            address.Add(contact);
        }
    }
}
   