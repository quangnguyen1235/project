using System;

namespace Colections_Contact
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneList Phonelist = new PhoneList(); 
            for (int i = 0; i < 3; i++)
            {
                Console.Write("input name");
                string name = Console.ReadLine();
                Console.Write("input PhoneNumber");
                string phoneNumber = Console.ReadLine();
                Phonelist.InsertPhoneNumber(name, phoneNumber);
            }
            Console.WriteLine("input name to update ");
            string nameupdate = Console.ReadLine();
            Phonelist.UpdatePhoneNumber(nameupdate);
            Phonelist.ShowContact();
        }
    }
}
