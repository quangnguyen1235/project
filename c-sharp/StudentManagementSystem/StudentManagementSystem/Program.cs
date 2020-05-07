using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace StudentManagementSystem
{
    class Program
    {
		public static Dictionary<int, Student> ListofStudent = new Dictionary<int, Student>();

		public static int Increment = 1;
        static void Main(string[] args)
        {
			ListofStudent.Add(1, new Student()
			{
				Class = "a",
				DateofBirth = DateTime.Parse("10/10/2000"),
				ID = 1,
				Mobile = 123234,
				Name = "Quang",
				Native = "Khoa",
				PhoneNo = "234353543"
			});
			ListofStudent.Add(2, new Student()
			{
				Class = "a",
				DateofBirth = DateTime.Parse("10/10/2000"),
				ID = 2,
				Mobile = 123234,
				Name = "Khoa",
				Native = "Khoa",
				PhoneNo = "234353543"
			});
			Menu();
        }
		public static void Menu()
		{
			int option = 0;
			do
			{
				Console.WriteLine("1. Insert new Student.");
				Console.WriteLine("2. View list of Students.");
				Console.WriteLine("3. Search Students.");
				Console.WriteLine("4. Exit.");
				Console.WriteLine();
				Console.Write("Your option: ");
				if (int.TryParse(Console.ReadLine(), out int number))
				{
					option = number;
				}
			} 
			while (option <1 || option > 4);
			Process(option);
		}
		public static void Process(int opt)
		{
			Console.Clear();
			switch (opt)
			{
				case 1:
					{
						InsertNewStudent();
						break;
					}
				case 2:
					{
						ViewListofStudent();
						break;
					}
				case 3:
					{
						SearchStudent();
						break;
					}
				case 4:
					{
						Environment.Exit(Environment.ExitCode);
						break;
					}
			}
			Menu();
		}
		static public void InsertNewStudent()
		{
			Student student = new Student();
			Console.Write("Input name: ");
			string name = Console.ReadLine();
			Console.Write("Input Date of birth: ");
			DateTime dob = DateTime.Parse(Console.ReadLine());
			Console.Write("Input Native: ");
			string native = Console.ReadLine();
			Console.Write("Input class: ");
			string classes = Console.ReadLine();
			Console.Write("Input PhoneNo: ");
			string phoneNo = Console.ReadLine();
			Console.Write("Input Mobile: ");
			int mobile = int.Parse(Console.ReadLine());
			student.Name = name;
			student.DateofBirth = dob;
			student.Native = native;
			student.Class = classes;
			student.PhoneNo = phoneNo;
			student.Mobile = mobile;
			student.ID = Increment;
			Increment++ ;
			ListofStudent.Add(student.ID, student);
		}
		public static void ViewListofStudent()
		{
			//foreach (var key in ListofStudent.Keys)
			//{
			//	ListofStudent[key].Display();
			//}
			foreach (KeyValuePair<int, Student> student in ListofStudent)
			{
				student.Value.Display();
			}
		}
		public static void SearchStudent()
		{
			int pos = -1;
			Console.Write("Input student's name to search: ");
			string nametoSearch = Console.ReadLine();
			foreach(var key in ListofStudent.Keys)
			{
				if(ListofStudent[key].Name == nametoSearch)
				{
					pos = key;
				}
			}
			//foreach (KeyValuePair<int, Student> student in ListofStudent)
			//{
			//	if (student.Value.Name == nametoSearch)
			//	{
			//		pos = (student.Value.ID);
			//	}
			//}
			if (pos >= 0)
			{
				ListofStudent[pos].Display();
			}
			else
			{
				Console.WriteLine("Student is not exist");
			}
		}
	}
}
