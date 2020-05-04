using System;
using System.Collections.Generic;
using System.Text;


namespace contact
{
    public class PhoneBook: Phone
    {
        public Contact[] PhoneList = new Contact[0];
        private int numOfContact => PhoneList.Length;
        public override void InsertPhone(string name, string phoneNumber)
        {
            Array.Resize(ref PhoneList, numOfContact + 1);
            PhoneList[numOfContact - 1] = new Contact(name, phoneNumber);
            Console.WriteLine("Insert new contact suscessfully!");
        }
        public override void RemovePhone(string name)
        {
            var pos = Check(name);
            if (pos >= 0)
            {
                for (int i = pos; i < numOfContact - 1; i++)
                {
                    PhoneList[i] = PhoneList[i + 1];
                }
                Array.Resize(ref PhoneList, numOfContact - 1);
                Console.WriteLine("Remove a contact suscessfully!");
            }
            else
            {
                Console.WriteLine("Contact is not exist!");
            }
        }
        public override void SearchPhone(string name)
        {
            var pos = Check(name);
            if (pos >= 0)
            {
                Console.WriteLine(PhoneList[pos].ShowContact());
            }
            else
            {
                Console.WriteLine("Contact is not exist!");
            }
        }
        public override void UpdatePhone(string name)
        {
            var pos = Check(name);
            if (pos >= 0)
            {
                Console.Write("Please input phonenumber: ");
                string PhoneNumber = Console.ReadLine();
                PhoneList[pos].PhoneNumber = PhoneNumber;
                Console.WriteLine("Update a contact suscessfully!");
            }
            else
            {
                Console.WriteLine("Contact is not exist!");
            }
        }
        public override void Sort(ref PhoneBook phoneBook)
        {
            Contact temp;
            for (int i = 0; i < numOfContact; i++)
            {
                for (int j = i + 1; j < numOfContact - 1; j++)
                {
                    if ((phoneBook.PhoneList[j].Name.CompareTo(phoneBook.PhoneList[j + 1].Name) > 0))
                    {
                        //cach trao doi gia tri
                        temp = phoneBook.PhoneList[j];
                        phoneBook.PhoneList[j] = phoneBook.PhoneList[j + 1];
                        phoneBook.PhoneList[j + 1] = temp;
                    }
                }
            }
        }
        private int Check(string name)
        {
            for (int i = 0; i < numOfContact; i++)
            {
                if (string.Compare(PhoneList[i].Name, name) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
