using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class Person // class 
    {       
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public static List<Person> people = new List<Person>(); // list

        // constructor1
        public Person()
        {

        }
        // constructor2
        public Person(string FirstName, string LastName, string Address, string City, string ZipCode, string PhoneNumber, string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.City = City;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            
        }
        // Method for input contact details  
        public void EntryDetails(int numContact)
        {
            for (int i = 0; i < numContact; i++)
            {
                Person person = new Person(); ;
                Console.WriteLine("Enter your 1st Name:");
                person.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your last Name:");
                person.LastName = Console.ReadLine();
                Console.WriteLine("Enter your Address:");
                person.Address = Console.ReadLine();
                Console.WriteLine("Enter your City:");
                person.City = Console.ReadLine();
                Console.WriteLine("Enter your Zip Code:");
                person.ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your Phone Number:");
                person.PhoneNumber = Console.ReadLine();
                Console.WriteLine("Enter your Email:");
                person.Email = Console.ReadLine();
                people.Add(person);
            }
        }
        // method for display contact details of adress book
        public static void DisplayAdressBook()
        {
           foreach (Person person in people )
           {
                Console.WriteLine("Here is the adress book of person");
                Console.WriteLine("First Name:" + person.FirstName);
                Console.WriteLine("Last Name:" + person.LastName);
                Console.WriteLine("Adress:" + person.Address);
                Console.WriteLine("City:" + person.City);
                Console.WriteLine("Zip Code:" + person.ZipCode);
                Console.WriteLine("Phone Number:" + person.PhoneNumber);
                Console.WriteLine("Email:" +person.Email);
                Console.WriteLine("***************************************************");
           }

        }
    }

}
