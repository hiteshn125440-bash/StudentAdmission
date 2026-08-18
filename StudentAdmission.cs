// Experiment 1
// AIM: Develop Student Admission Management Module using OOP Concepts
// (Class, Object, Constructor, Access Modifiers).

using System;

namespace StudentAdmissionManagement
{
    class Student
    {
        private int studentId;
        private string studentName;
        private string course;

        public Student(int id, string name, string courseName)
        {
            studentId = id;
            studentName = name;
            course = courseName;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n------ Student Details ------");
            Console.WriteLine("Student ID   : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("Course       : " + course);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Course: ");
            string course = Console.ReadLine();

            Student s1 = new Student(id, name, course);

            s1.DisplayDetails();

            Console.ReadKey();
        }
    }
}
