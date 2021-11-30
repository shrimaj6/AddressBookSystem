using System;

namespace AddressBookSystem4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter number of contact entries you want to have: ");
            int num = int.Parse(Console.ReadLine());

            ContactPerson obj = new ContactPerson();
            for (int i = 0; i < num; i++)
            {

                obj.AddContact();
            }
            Console.WriteLine("Do you want to see Addressbook entries(y/Y) :");
            char ch = char.Parse(Console.ReadLine());
            if (ch == 'y' || ch == 'Y')
            {
                obj.displayContact();
            }

            Console.WriteLine("You Want to update(y/n) :");
            char ch11 = char.Parse(Console.ReadLine());
            if (ch11 == 'y')
            {
                Console.WriteLine("Enter name You Want to update :");
                string str1 = Console.ReadLine();
                obj.updateContact(str1);
            }


            Console.WriteLine("Do you want to see Addressbook entries(y/Y) :");
            char ch2 = char.Parse(Console.ReadLine());
            if (ch2 == 'y' || ch2 == 'Y')
            {
                obj.displayContact();
            }
        }
    }
}