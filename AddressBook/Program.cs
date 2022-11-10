using System;
using System.ComponentModel.DataAnnotations;

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
                Console.WriteLine("Select 1.To Create Contact " + "\n" + 
                    "2.To Edit Contact" + " \n" + 
                    "3.To Delete Contact" + " \n"+
                    "4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        create.CreateContact();
                        create.Display();
                        break;
                    case 2:
                        create.EditContact("String");
                        create.Display();
                        break;
                    case 3:
                        create.DeleteContact("String");
                        create.Display();
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}