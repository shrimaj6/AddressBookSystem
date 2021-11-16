using System;

namespace AddressBookSystem
{
    class Program
    {
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
            Console.WriteLine(this.FirstName + " " + this.LastName + " " + this.City + " " + this.Address + " " + this.State + " " + this.ZipCode + " " + this.PhoneNumber + " " + this.Email);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Firstname,LastName,Address,City,State,Zipcode,Phone,Email\n");


            Program obj = new Program()//object initializer
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
            obj.displayContact();
        }
    }
}