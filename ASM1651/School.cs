using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASM1651
{
    class School
    {
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();

        public void AddStudent()
        {
            Console.Write("Enter Student ID: ");
            //int id = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Student Sex: ");
            string sex = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Student Grade: ");
            double grade = double.Parse(Console.ReadLine());
            Console.Write("Enter Student Class: ");
            string classes = Console.ReadLine();
            Student student = new Student(id, name, sex, age, phone, grade, classes);
            Console.WriteLine("                               ");
            //add student in list student
            students.Add(student);
            student.NotifyWhenAdded();
            Console.WriteLine("                               ");
        }
        public void ShowStudent()
        {
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("List students is empty. Please Add Student!");
                AddStudent();
            }

            foreach (Student student in students)
            {
                student.DisplayInfo();
            }
        }
        public void UpdateStudent()
        {
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("List students is empty. Please Add Student!");
                AddStudent();
            }
            Console.Write("Enter Student ID Update: ");
            string idStudentUpdate = Console.ReadLine();
            //if (String.IsNullOrEmpty(idStudentUpdate))
            //{
            //    Console.WriteLine("Please Enter Student ID Update.");
            //}
            //Student studentUpdate = null;
            //foreach (Student student in students)
            //{
            //    if (!String.IsNullOrEmpty(student.ID) && student.ID.Equals(idStudentUpdate))
            //    {
            //        studentUpdate = student;
            //    }
            //}


            //if (studentUpdate == null)
            //{
            //    Console.WriteLine("Student not found!");
            //}
            //else // Founded
            //{
            //    studentUpdate.DisplayInfo();
            //    Console.WriteLine("Student updated successfully!");
            //}
        }
        public void DeleteStudent()
        {
            Student student1 = new Student();
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("List students is empty. Please Add Student!");
                AddStudent();
            }
            Console.Write("Enter Student ID Delete: ");
            string idStudentDelete = Console.ReadLine();
            if (String.IsNullOrEmpty(idStudentDelete))
            {
                Console.WriteLine("Please input ID for delete student.");
            }
            Student studentDelete = null;
            foreach (Student student in students)
            {
                if (!String.IsNullOrEmpty(student.ID)
                    && student.ID.Equals(idStudentDelete))
                {
                    studentDelete = student;
                }
            }
            if (studentDelete == null)
            {
                Console.WriteLine("Student not found!");
            }
            else 
            {
                student1.NotifyWhenupdated();
                students.Remove(studentDelete);
            }
        }
        public void AddTeacher()
        {
            Console.Write("Enter Teacher ID: ");
            //int id = int.Parse(Console.ReadLine());
            string id = Console.ReadLine();
            Console.Write("Enter Teacher Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Teacher Sex: ");
            string sex = Console.ReadLine();
            Console.Write("Enter Teacher Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Teacher Phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter Teacher Subject: ");
            string subject = Console.ReadLine();
            Console.Write("Enter Teacher Year of Experience: ");
            int yearExperience = int.Parse(Console.ReadLine());
            Console.Write("Enter Teacher Email: ");
            string email = Console.ReadLine();
            Teacher teacher = new Teacher(id, name, sex, age, phone, subject, yearExperience, email);
            Console.WriteLine("                               ");
            //add teacher in list teacher
            teachers.Add(teacher);
            teacher.NotifyWhenAdded();
            Console.WriteLine("                               ");

        }
        public void ShowTeacher()
        {
            if (teachers == null || teachers.Count == 0)
            {
                Console.WriteLine("Please Add Teacher.");
                AddTeacher();
            }
            foreach (Teacher teacher in teachers)
            {
                teacher.DisplayInfo();
            }
        }
        public void UpdateTeacher()
        {
        }
        public void DeleteTeacher()
        {
            Teacher teacher1 = new Teacher();
            if (teachers == null || teachers.Count == 0)
            {
                Console.WriteLine("List students is empty. Please Add Student!");
                AddTeacher();
            }
            Console.Write("Enter Student ID Delete: ");
            string idTeacherDelete = Console.ReadLine();
            if (String.IsNullOrEmpty(idTeacherDelete))
            {
                Console.WriteLine("Please input ID for delete student.");
            }
            Student teacherDelete = null;
            foreach (Teacher teacher in teachers)
            {
                if (!String.IsNullOrEmpty(teacher.ID)
                    && teacher.ID.Equals(idTeacherDelete))
                {
                    teacherDelete = teacher;
                }
            }
            if (teacherDelete == null)
            {
                Console.WriteLine("Student not found!");
            }
            else 
            {
                teacher1.NotifyWhenDeleted();   
                students.Remove(teacherDelete);
            }
        }
    }
}
