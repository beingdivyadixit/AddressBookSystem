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
            Console.WriteLine("Enter: \n1: Ability to create a Contacts in AdressBook\n2: Ability to add a new Contact to Address Book\n3: Edit Contact From Adress Book\n4: Delete contact \n5: Multiple contact"); // taken options of program input from user
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
                case 4:
                    {  //uc4
                        Console.WriteLine("Enter the Number of Contact You Wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person obj = new Person();
                        obj.EntryDetails(numContact);
                        Person.DisplayAdressBook();
                        Console.WriteLine("enter the first name of contact you want to delete");
                        string name=Convert.ToString(Console.ReadLine());
                        obj.deleteContact(name);
                        Person.DisplayAdressBook();

                    }
                    break;
                case 5:
                    {  // UC5
                        Console.WriteLine("Enter the Number of Contact You Wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person obj = new Person();
                        obj.EntryDetails(numContact);
                        Person.DisplayAdressBook();
                    }
                    break;

                default:
                    Console.WriteLine("Please Enter The Valid Option");
                    break;
            }
        }
    }
}
