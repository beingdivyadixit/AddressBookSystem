using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Person
    {       
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string ZipCode { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }
            public static List<Person> People = new List<Person>();
           // public Person person = new Person();
        public static void EntryDetails()
        {
            Person person = new Person();
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
            People.Add(person);

        }

        public static void DisplayAdressBook()
        {
           // Person person = new Person();
            foreach (Person person in People )
            {
                Console.WriteLine("Here is the adress book of person");
                Console.WriteLine("First Name:" + person.FirstName);
                Console.WriteLine("Last Name:" + person.LastName);
                Console.WriteLine("Adress:" + person.Address);
                Console.WriteLine("City:" + person.City);
                Console.WriteLine("Zip Code:" + person.ZipCode);
                Console.WriteLine("Phone Number:" + person.PhoneNumber);
                Console.WriteLine("Email:" +person.Email);
            }



        }
        
    }  
    
}
