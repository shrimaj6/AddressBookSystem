using System;

namespace AddressBookSystem2
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

        }
    }
}