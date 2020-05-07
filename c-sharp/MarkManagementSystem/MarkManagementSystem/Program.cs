using System;
using System.Collections.Generic;

namespace MarkManagementSystem
{
    class Program
    {
		public static Dictionary<int, Student> ListofStudents = new Dictionary<int, Student>();
		public static int Increment = 1;
        static void Main(string[] args)
        {
			Menu();
        }
		public static void Menu()
		{
			int option = 0;
			do
			{
				Console.WriteLine("1. Insert new Student.");
				Console.WriteLine("2. View list of Students.");
				Console.WriteLine("3. Calculator average Marks.");
				Console.WriteLine("4. Exit.");
				Console.WriteLine();
				Console.Write("Your option: ");
				if (int.TryParse(Console.ReadLine(), out int number))
				{
					option = number;
				}
			}
			while (option < 1 || option > 4);
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
						AveCal();
						ViewListofStudent();
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
		public static void InsertNewStudent()
		{
			Console.Write("Please input Student's Name: ");
			string fullName = Console.ReadLine();
			Console.Write("Please input Class: ");
			string _class = Console.ReadLine();
			Console.Write("Please input Semester: ");
			int semester = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter rate: ");
			int id = Increment;
			Increment++ ;
			Student student = new Student(id, fullName, _class, semester);
			for (int i = 0; i < student.SubjectMarkList.Length; i++)
			{
				Console.Write($"Rate {i + 1}: ");
				student.SubjectMarkList[i] = int.Parse(Console.ReadLine());
			}
			ListofStudents.Add(student.ID, student);
		}
		public static void ViewListofStudent()
		{
			foreach(KeyValuePair<int, Student> student in ListofStudents)
			{
				student.Value.DisPlay();
			}
		}
		public static void AveCal()
		{
			foreach (KeyValuePair<int, Student> student in ListofStudents)
			{
				student.Value.Calculator();
			}
		}
	}
}
