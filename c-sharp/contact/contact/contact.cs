using System;
using System.Collections.Generic;
using System.Text;


namespace contact
{
    public class Contact
    {
        private string name;
        private string phoneNumber;
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string PhoneNumber
        {
            get => phoneNumber;
            set => phoneNumber = value;
        }
        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
    }
    public class PhoneBook
    {
        
        Contact[] contactList = new Contact[0];
        public void Add(Contact newContact)
        {
            Array.Resize(ref contactList, contactList.Length + 1);
            contactList[contactList.Length - 1] = newContact;
            Console.WriteLine("Done!");
            Console.Write("Please enter to continue...");
            Console.ReadKey();
        }
        public bool Check(string name)
        {
            bool result = false;
            for(int i = 0; i < contactList.Length; i++)
            {
                if (name == contactList[i].Name)
                {
                    break;
                }
            }
            return result = true;
        }
        public void Update(string name, string phoneNumber )
        {
            if (contactList.Length == 0)
            {
                Console.WriteLine("Please input new contact first");
            }
            else
            {
                 for (int i = 0; i < contactList.Length; i++)
                {
                    if (Check(name))
                    {
                        contactList[i].PhoneNumber = phoneNumber;
                        Console.WriteLine("Done!");
                        Console.Write("Please enter to continue...");
                        Console.ReadKey();

                    }
                }
            }
        }
        public void Remove(string name)
        {
            if (contactList.Length == 0)
            {
                Console.WriteLine("Please input new contact first");
            }
            else
            {
                for (int i = 0; i < contactList.Length; i++)
                {
                    if (Check(name))
                    {
                        List<Contact> list = new List<Contact>(contactList);
                        list.RemoveAt(i);
                        contactList = list.ToArray();
                        Console.WriteLine("Done!");
                        Console.Write("Please enter to continue...");
                        Console.ReadKey();
                    }
                }
            }
        }
        public void Search(string name)
        {
            Console.Clear();
            if (contactList.Length == 0)
            {
                
                Console.WriteLine("Please input new contact first");
                
            }
            else
            {
                for (int i = 0; i < contactList.Length; i++)
                {
                    if (Check(name))
                    {
                        Console.Write($"Name: {contactList[i].Name} \t");
                        Console.WriteLine($"Phonenumber: {contactList[i].PhoneNumber}");
                        Console.Write("Please enter to continue...");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not exists");
                        Console.Write("Please enter to continue...");
                        Console.ReadKey();
                        break;
                    }
                }
            }
        }
        public void ShowContact()
        {
            for (int i = 0; i < contactList.Length; i++)
            {
                Console.WriteLine($"Name: {contactList[i].Name}\t Phonenumber: {contactList[i].PhoneNumber}");
                Console.Write("Please enter to continue...");
                Console.ReadKey();
            }
        }
    }
}
