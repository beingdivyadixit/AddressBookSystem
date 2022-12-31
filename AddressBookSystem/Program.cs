using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {   // start
            Console.WriteLine("Welcome to AddressBook Program");
            Console.WriteLine("Enter: \n1: Ability to create a Contacts in AdressBook\n2: Ability to add a new Contact to Address Book\n3: Edit Contact From Adress Book"); // taken options of program input from user
            int option =Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    {   //UC1
                        Console.WriteLine("Enter the Number of Contact You Wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person entryDetails = new Person();
                        entryDetails.EntryDetails(numContact);
                    }
                    break;
                case 2:
                    {    //UC2
                        Console.WriteLine("Enter the Number of Contact You Wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person entryDetails = new Person();
                        entryDetails.EntryDetails(numContact);
                        Person.DisplayAdressBook();
                    }
                    break;
                case 3:
                    {   //UC3
                        Console.WriteLine("Enter the Number of Contact You Wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person entryDetails = new Person();
                        entryDetails.EntryDetails(numContact);
                        Person.DisplayAdressBook();
                        Console.WriteLine("Enter the first name you want to edit information");
                        string name = Convert.ToString(Console.ReadLine());
                        entryDetails.EditContact(name);
                    }
                    break;
                default:
                    Console.WriteLine("Please Enter The Valid Option");
                    break;
            }
        }
    }
}
