using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
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
            //Enter student information
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());
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
            //add students to the list
            students.Add(student);
            student.NotifyWhenAdded();
            Console.WriteLine("                               ");
        }
        public void ShowStudent()
        {
            //show students
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
            //update students
            Student student1 = new Student();
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("List students is empty. Please Add Student!");
                AddStudent();
            }
            Console.Write("Enter Student ID Update: ");
            int idStudentUpdate = int.Parse(Console.ReadLine());
            while (idStudentUpdate.ToString() == "")
            {
                Console.WriteLine("Please input ID for update student.");
                idStudentUpdate = int.Parse(Console.ReadLine());
            }
            foreach (Student student in students)
            {
                if (student.IDs == idStudentUpdate)
                {
                    Console.WriteLine("Please enter infomation update:");
                    Console.WriteLine("ID student: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Name student: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Sex student: ");
                    string sex = Console.ReadLine();
                    Console.WriteLine("Age student: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Phone student: ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Grade student: ");
                    double grade = double.Parse(Console.ReadLine());
                    Console.WriteLine("Class student: ");
                    string classes = Console.ReadLine();

                    student.Grades= grade;
                    student.IDs = id;
                    student.Name = name;
                    student.Sex = sex;
                    student.Age = age;
                    student.Phone = phone;
                    student.Classes = classes;
                    //student.ParentPhoneNumber = parentPhoneNumber;
                    Console.WriteLine("Update Sucessfuly!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please re-enter the student ID you want to update:");

                }
            }
        }
        public void DeleteStudent()
        {
            //delet students
            Student student1 = new Student();
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("List students is empty. Please Add Student!");
                AddStudent();
            }
            Console.Write("Enter Student ID Delete: ");
            int idStudentDelete = int.Parse(Console.ReadLine());
            while(idStudentDelete.ToString() == "")
            {
                Console.WriteLine("Please input ID for delete student.");
                idStudentDelete = int.Parse(Console.ReadLine());
            }
            foreach (Student student in students)
            {
                if ( student.IDs == idStudentDelete)
                {
                    students.Remove(student);
                    Console.WriteLine("Delete Sucessfuly!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please re-enter the student ID you want to delete:");

                }
            }

        }
        public void AddTeacher()
        {
            Console.Write("Enter Teacher ID: ");
            int id = int.Parse(Console.ReadLine());
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
            Console.Write("Enter Teacher Salary: ");
            int Salary = int.Parse(Console.ReadLine());
            Console.Write("Enter Teacher Email: ");
            string email = Console.ReadLine();
            Teacher teacher = new Teacher(id, name, sex, age, phone, subject, yearExperience,Salary, email);
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
            Teacher teacher1 = new Teacher();
            if (teachers == null || teachers.Count == 0)
            {
                Console.WriteLine("List teachers is empty. Please Add Teacher!");
                AddTeacher();
            }
            Console.Write("Enter Teacher ID Update: ");
            int idTeacherUpdate = int.Parse(Console.ReadLine());
            while (idTeacherUpdate.ToString() == "")
            {
                Console.WriteLine("Please input ID for update teacher.");
                idTeacherUpdate = int.Parse(Console.ReadLine());
            }
            foreach (Teacher teacher in teachers)
            {
                if (teacher.IDs == idTeacherUpdate)
                {
                    Console.WriteLine("Please enter infomation update:");
                    Console.Write("Enter Teacher Position: ");
                    string position = Console.ReadLine();
                    Console.WriteLine("ID Teacher: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Name Teacher: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Sex Teacher: ");
                    string sex = Console.ReadLine();
                    Console.WriteLine("Age Teacher: ");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Phone Teacher: ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Subject Teacher: ");
                    string subject = Console.ReadLine();
                    Console.WriteLine("Year Experience Teacher: ");
                    int yearExperience = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Teacher Salary: ");
                    int Salary = int.Parse(Console.ReadLine());
                    Console.WriteLine("Email Teacher: ");
                    string email = Console.ReadLine();

                    teacher.IDs = id;
                    teacher.Name = name;
                    teacher.Sex = sex;
                    teacher.Age = age;
                    teacher.Phone = phone;
                    teacher.Subject = subject;
                    teacher.YearExperience = yearExperience;
                    teacher.Email = email;
                    Console.WriteLine("Update Sucessfuly!");
                    break;
                }
                else {Console.WriteLine("Please re-enter the student ID you want to update: "); }
            }
        }
        public void DeleteTeacher()
        {
            //delete students
            Teacher teacher1 = new Teacher();
            if (teachers == null || teachers.Count == 0)
            {
                Console.WriteLine("List teachers is empty. Please Add Teacher!");
                AddTeacher();
            }
            Console.Write("Enter Teacher ID Delete: ");
            int idTeacherDelete = int.Parse(Console.ReadLine());
            while (idTeacherDelete.ToString() == "")
            {
                Console.WriteLine("Please input ID for delete teacher.");
                idTeacherDelete = int.Parse(Console.ReadLine());
            }

            foreach (Teacher teacher in teachers)
            {
                if (teacher.IDs == idTeacherDelete)
                {
                    teachers.Remove(teacher);
                    Console.WriteLine("Delete Sucessfuly!");
                    break;
                }
                else { Console.WriteLine("Please re-enter the student ID you want to delete: "); }
            }
        }

    }
}
