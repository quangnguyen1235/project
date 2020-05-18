using StudentManagementJson.Service;
using System;

namespace StudentManagementJson
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"C:\Users\Admin\Documents\project\project\c-sharp\StudentManagementJson\StudentManagementJson\Files\Students.json";
            string output = @"C:\Users\Admin\Documents\project\project\c-sharp\StudentManagementJson\StudentManagementJson\Files\SutdentOutput.json";
            JsonService jsonService = new JsonService(input, output);
            jsonService.ReadFile();
            jsonService.WriteFile();
        }
    }
}
