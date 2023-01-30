using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class Person // class 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string addressBookName { get; set; }
        public static List<Person> people=new List<Person>(); // list
        public Dictionary<string, List<Person>> contactDictionary = new Dictionary<string, List<Person>>();

        // default constructor
        public Person()
        {

        }
        // constructor with parameter
        public Person(string adressBookName, string firstName, string lastName, string address, string city, string zipCode, string phoneNumber, string email)
        {
            this.addressBookName = addressBookName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
          
        }
        // Method for input contact details  
        public void EntryDetails()
        {
            Console.WriteLine("Enter the Number of Contact You Wanted to make");
            int numContact = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numContact; i++)
            {
                Person person = new Person();
                Console.WriteLine("Enter the details of Contact {0}",i); ;
                Console.WriteLine("Enter your 1st Name:");
                person.firstName = Console.ReadLine();
                Console.WriteLine("Enter your last Name:");
                person.lastName = Console.ReadLine();
                Console.WriteLine("Enter your Address:");
                person.address = Console.ReadLine();
                Console.WriteLine("Enter your City:");
                person.city = Console.ReadLine();
                Console.WriteLine("Enter your Zip Code:");
                person.zipCode = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number:");
                person.phoneNumber = Console.ReadLine();
                Console.WriteLine("Enter your Email:");
                person.email = Console.ReadLine();
                if (people.Count > 0)
                {
                    var result = people.Where(p => p.firstName == firstName).ToList();
                    if (result.Count > 0)
                    {
                        people.Add(person);
                    }
                    else
                    {
                        Console.WriteLine("Dulicate Input\n************************");
                    }
                }
                else
                {
                    people.Add(person);
                }
            }
        }
        // method for display contact details of adress book
        public void DisplayAdressBook()
        {
            foreach (Person person in people)
            {
                Console.WriteLine("Displaying the person details\n");
                Console.WriteLine("First Name:" + person.firstName) ;
                Console.WriteLine("Last Name:" + person.lastName);
                Console.WriteLine("Adress:" + person.address);
                Console.WriteLine("City:" + person.city);
                Console.WriteLine("Zip Code:" + person.zipCode);
                Console.WriteLine("Phone Number:" + person.phoneNumber);
                Console.WriteLine("Email:" + person.email);
                Console.WriteLine("***************************************************");
            }

        }
        // Method for editing contact details
        public void EditContact()
        {
            Console.WriteLine("Enter the first name you want to edit information");
            string name = Convert.ToString(Console.ReadLine());
            bool input = false;
            Console.WriteLine("Enter: \n 1 for edit first name \n 2 for edit last name \n 3 for edit adress \n 4 for edit city \n 5 for edit zip code \n 6 for edit phone number \n 7 for edit email ");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (var person in people)
            {
                if (person.firstName == name) // if statement
                {
                    input = true;
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter Curent first name :");
                            string currentFirstName = Convert.ToString(Console.ReadLine());
                            person.firstName = currentFirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Curent last name :");
                            string currentLastName = Convert.ToString(Console.ReadLine());
                            person.lastName = currentLastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter Curent City Address :");
                            string currentAddress = Convert.ToString(Console.ReadLine());
                            person.address = currentAddress;
                            break;
                        case 4:
                            Console.WriteLine("Enter Curent City :");
                            string currentCity = Convert.ToString(Console.ReadLine());
                            person.city = currentCity;
                            break;
                        case 5:
                            Console.WriteLine("Enter Curent Zip Code :");
                            string currentZipCode = Convert.ToString(Console.ReadLine());
                            person.zipCode = currentZipCode;
                            break;
                        case 6:
                            Console.WriteLine("Enter Curent Phone Number :");
                            string currentPhoneNumber = Convert.ToString(Console.ReadLine());
                            person.phoneNumber = currentPhoneNumber;
                            break;
                        case 7:
                            Console.WriteLine("Enter Curent Email :");
                            string currentEmail = Convert.ToString(Console.ReadLine());
                            person.email = currentEmail;
                            break;
                        default:
                            Console.WriteLine("Please Enter valid Option");
                            break;
                    }

                }

            }
            if (input == false)
                Console.WriteLine("First name not found");
            
        }
        public void deleteContact()
        {   bool input = false;
            Console.WriteLine("enter the first name of contact you want to delete");
            string name = Convert.ToString(Console.ReadLine());
            foreach (var person1 in people)
            {
                if (person1.firstName == name) // if statement
                {
                    input = true;
                    people.Remove(person1); // for delting 
                    Console.WriteLine("adress book of person after remove");
                    break;
                }
            }
            if (input == false) // if statement
                Console.WriteLine("Contact not present");
        }
        public void AddNewAddressBook()
        {
            //Creating a dictionary
            
            Person person = new Person();
            Console.WriteLine("How many number of address books you want to add ");
            int numberOfAdreBooks = Convert.ToInt32(Console.ReadLine());
            while (numberOfAdreBooks > 0)
            {
                Console.WriteLine("Enter name of the address book:");
                string addressBookName = Console.ReadLine();
                EntryDetails();
                contactDictionary.Add(addressBookName,people);  // to store book name and contacts in dictionary
                Console.WriteLine(" \n"+addressBookName);
                DisplayAdressBook(); //to display contacts
                numberOfAdreBooks--;
            }
        }
    }
}
