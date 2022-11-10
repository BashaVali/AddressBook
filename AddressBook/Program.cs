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
                    "4.To Create Dictionary" + "\n"+
                    "5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        create.CreateContact();
                        create.Display();
                        break;
                    case 2:
                        create.EditContact();
                        create.Display();
                        break;
                    case 3:
                        create.DeleteContact();
                        create.Display();
                        break;
                    case 4:
                        create.CreateDictionary();
                        create.Display();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}