using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addrssbook
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "Pratik";
            addressBook.lastName = "Bhandurge";
            addressBook.address = "vimannager";
            addressBook.city = "pune";
            addressBook.state = "maharashtra";
            addressBook.zip = 412207;
            addressBook.phoneNumber = 1234567890;
            addressBook.email = "pb@gmail.com";
        }
    }
}