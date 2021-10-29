using System;

namespace Day23AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to AddressBook");

            AddressBook.AddContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.EditContact();
            Console.WriteLine("\n");
            AddressBook.ContactsDisplay();
            Console.WriteLine("\n");
            AddressBook.DeleteContact();
            AddressBook.ContactsDisplay();
        }
    }
}
