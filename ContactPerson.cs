using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddressBookSystem2
{
    class ContactPerson
    {
        List<ContactPerson> objList = new List<ContactPerson>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public double PhoneNumber { get; set; }
        public string Email { get; set; }
        public void displayContact()
        {
            foreach (var item in objList)
            {
                Console.WriteLine(item.FirstName + " " + item.City + " " + item.State + " " + item.ZipCode + " " + item.PhoneNumber + " " + item.Email);
            }
            //Console.WriteLine(this.FirstName + " " + this.City + " " + this.State + " " + this.ZipCode + " " + this.PhoneNumber + " " + this.Email);


        }
        //  public int siz()
        //{
        //  return objList.Count();
        //}
        public void deleteContact(string s)
        {
            foreach (var item in objList)
            {
                if (item.FirstName == s)
                {
                    objList.Remove(item);
                    return;
                }
            }
        }
        public void AddContact()
        {


            Console.WriteLine("Enter Firstname,LastName,Address,City,State,Zipcode,Phone,Email\n");


            ContactPerson contact = new ContactPerson()//object initializer
            {
                FirstName = Console.ReadLine(),
                LastName = Console.ReadLine(),
                Address = Console.ReadLine(),
                City = Console.ReadLine(),
                State = Console.ReadLine(),
                ZipCode = Convert.ToInt32(Console.ReadLine()),
                PhoneNumber = Convert.ToDouble(Console.ReadLine()),
                Email = Console.ReadLine(),

            };

            objList.Add(contact);

            //contact.displayContact();


            Console.ReadKey();
        }

    }
}