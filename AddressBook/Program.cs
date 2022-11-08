using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookMain create = new AddressBookMain();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select 1.To Create Contact 2.To Edit Contact 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        create.CreateContact();                     
                        break;
                  
                }
            }
        }
    }
}