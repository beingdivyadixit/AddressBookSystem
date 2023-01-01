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

        // default constructor
        public Person()
        {

        }
        // constructor
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
        // Method for editing contact details
        public void EditContact(string name)
        {
            bool input = false;
            Console.WriteLine("Enter: \n 1 for edit first name \n 2 for edit last name \n 3 for edit adress \n 4 for edit city \n 5 for edit zip code \n 6 for edit phone number \n 7 for edit email ");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (Person person in people)
            {
                if (person.FirstName == name) // if statement
                {
                    input = true;
                    switch (option) 
                    {
                        case 1:
                            Console.WriteLine("Enter Curent first name :");
                            string currentFirstName = Convert.ToString(Console.ReadLine());
                            person.FirstName = currentFirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter Curent last name :");
                            string currentLastName = Convert.ToString(Console.ReadLine());
                            person.LastName = currentLastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter Curent City Address :");
                            string currentAddress = Convert.ToString(Console.ReadLine());
                            person.Address = currentAddress;
                            break;
                        case 4:
                            Console.WriteLine("Enter Curent City :");
                            string currentCity = Convert.ToString(Console.ReadLine());
                            person.City = currentCity;
                            break;
                        case 5:
                            Console.WriteLine("Enter Curent Zip Code :");
                            string currentZipCode = Convert.ToString(Console.ReadLine());
                            person.ZipCode = currentZipCode;
                            break;
                        case 6:
                            Console.WriteLine("Enter Curent Phone Number :");
                            string currentPhoneNumber = Convert.ToString(Console.ReadLine());
                            person.PhoneNumber = currentPhoneNumber;
                            break;
                        case 7:
                            Console.WriteLine("Enter Curent Email :");
                            string currentEmail = Convert.ToString(Console.ReadLine());
                            person.Email = currentEmail;
                            break;
                        default:
                            Console.WriteLine("Please Enter valid Option");
                            break;
                    }

                }
               
            }
            if(input==false)
            Console.WriteLine("First name not found");
            Person.DisplayAdressBook();  // calling method for displaying after edit
        }
        public void deleteContact(string name)
        { bool input = false;
          foreach (Person person1 in people)
          {
               if (person1.FirstName == name) // if statement
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
    }

}
