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

        public AddressBook(string firstName, String lastName, String address, String city, String state, long zip, long phoneNumber, String email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public AddressBook()
        {

        }

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "Partik";
            addressBook.lastName = "BHandurge";
            addressBook.address = "Vimannager";
            addressBook.city = "Pune";
            addressBook.state = "maharashtra";
            addressBook.zip = 412207;
            addressBook.phoneNumber = 1234567890;
            addressBook.email = "pb@gmail.com";
        }
    }
}