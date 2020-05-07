using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Colections_Contact
{
    public class PhoneList : Phone
    {
        ArrayList Phonelist = new ArrayList();
        private int NumOfPhone => Phonelist.Count;
        public override void InsertPhoneNumber(string name, string phoneNumber)
        {
            Phonelist.Add(new Contact(name, phoneNumber));
        }

        public override void RemovePhoneNumber(string name)
        {
            int pos = Check(name);
            if (pos >= 0)
            {
                Phonelist.RemoveAt(pos);
            }
            else
            {
                Console.WriteLine("Element is not Exist");
            }
        }

        public override void SearchPhoneNumber(string name)
        {
            int pos = Check(name);
            if (pos >= 0)
            {
                ((Contact)pos).ToString();
            }
            else
            {
                Console.WriteLine("Element is not Exist");
            }
        }

        public override void SoftPhoneNumber()
        {
            new SoftPhoneNumber();
        }

        public override void UpdatePhoneNumber(string name)
        {
            //int pos = Phonelist.IndexOf(name);
            int pos = Check(name);
            if (pos >= 0)
            {
                Phonelist.RemoveAt(pos);
                Console.WriteLine("Please edit PhoneNumber: ");
                string phoneNumber = Console.ReadLine();
                Phonelist.Insert(pos, new Contact(name, phoneNumber));
            }
            else
            {
                Console.WriteLine("Element is not Exist");
            }
        }
        public void ShowContact()
        {
            foreach(var item in Phonelist)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private int Check(string name)
        {
            for (int i = 0; i < Phonelist.Count; i++)
            {
                Contact ct = Phonelist[i] as Contact;
                if (ct.Name == name)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
