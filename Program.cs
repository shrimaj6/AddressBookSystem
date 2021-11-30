using System;

namespace AddressBookSystem3
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
            //int v = obj.siz();
            //0Console.WriteLine(v);
            Console.WriteLine("enter name you want to remove :");
            string str = Console.ReadLine();
            obj.deleteContact(str);

            Console.WriteLine("Do you want to see Addressbook entries(y/Y) :");
            char ch1 = char.Parse(Console.ReadLine());
            if (ch1 == 'y' || ch1 == 'Y')
            {
                obj.displayContact();
            }

            Console.WriteLine("Enter name You Want to update :");
            string str1 = Console.ReadLine();
            obj.updateContact(str1);



            Console.WriteLine("Do you want to see Addressbook entries(y/Y) :");
            char ch2 = char.Parse(Console.ReadLine());
            if (ch2 == 'y' || ch2 == 'Y')
            {
                obj.displayContact();
            }

        }
    }
}