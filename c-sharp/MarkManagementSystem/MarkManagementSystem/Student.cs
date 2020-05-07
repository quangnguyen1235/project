using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MarkManagementSystem
{
    class Student : IStudentMark
    {
        private string fullName;
        private int id;
        private string _class;
        private int semester;
        private float averageMark;
        public string FullName { get => fullName; set => fullName = value; }
        public int ID { get => id; set => id = value; }
        public string Class { get => _class; set => _class = value; }
        public int Semester { get => semester; set => semester = value; }

        public float AverageMark => averageMark;
        public float[] SubjectMarkList = new float[5];
        public Student(int id, string fullName, string _class, int semester)
        {
            this.id = id;
            this.fullName = fullName;
            this.semester = semester;
            this._class = _class;
        }

        public void DisPlay()
        {
            Console.WriteLine($"{id} FullName: {fullName}\t Class: {_class}\t Semester: {semester}\t AverageMark: {averageMark}");
        }
        public void Calculator()
        {
            float total = 0;
            //foreach (var item in SubjectMarkList)
            //{
            //    total += SubjectMarkList[item];
            //}
            for (int i = 0; i < SubjectMarkList.Length; i++)
            {
                total += SubjectMarkList[i];
            }
            averageMark = total / SubjectMarkList.Length;
        }
    }
}
