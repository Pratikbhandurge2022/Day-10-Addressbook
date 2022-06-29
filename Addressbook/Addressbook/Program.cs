using System;

namespace Addrssbook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            String lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            String address = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state");
            String state = Console.ReadLine();

            Console.WriteLine("enter zip");
            long zip = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter phone number");
            long phNo = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter email");
            String email = Console.ReadLine();

            AddressBook addressBook = new AddressBook(firstName, lastName, address, city, state, zip, phNo, email);


        }
    }
}