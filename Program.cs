using System;

namespace Day23AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to AddressBook");

            AddressBook.AddContact();
            AddressBook.ContactsDisplay();
            AddressBook.EditContact();
            AddressBook.ContactsDisplay();

        }
    }
}
