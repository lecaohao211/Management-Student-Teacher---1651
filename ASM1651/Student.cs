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
    class Student : Person
    {
        private double Grade { get; set; }
        public string Classes { get; set; }
        //private string ParentPhoneNumber { get; set; }
        public Student(int id, string name, string sex, int age, string phone, double grade, string classes) : base(id, name, sex, age, phone)
        {
            Grade = grade;
            Classes = classes;
            //ParentPhoneNumber = parentPhoneNumber;
        }

        public Student()
        {
        }
        //public void setGrade(double grade)
        //{
        //    Grade = grade;
        //}
        public double Grades
        {
            get { return Grade; }
            set { Grade = value; }
        }

        //Display student information
        public override void DisplayInfo()
        {
            Console.WriteLine("=========STUDENT LIST=========");
            Console.WriteLine("Student ID:    " + ID);
            Console.WriteLine("Student Name:  " + Name);
            Console.WriteLine("Student Sex:   " + Sex);
            Console.WriteLine("Student Age:   " + Age);
            Console.WriteLine("Student Phone: " + Phone);
            Console.WriteLine("Student Grade: " + Grade);
            Console.WriteLine("Student Class: " + Classes);
            //Console.WriteLine("Parent Phone Number: " + ParentPhoneNumber);
            Console.WriteLine("===============================");
            Console.WriteLine("                               ");
        }
        //Notification when adding students successfully
        public override void NotifyWhenAdded()
        {
            Console.WriteLine("Add Student Successfully!");
        }
        //Notification when student update is successful
        public override void NotifyWhenupdated()
        {
            Console.WriteLine("Update Student Successfully!");
        }
        //Notice when deleting students successfully
        public override void NotifyWhenDeleted()
        {
            Console.WriteLine("Delete Student Successfully!");
        }



        //public static implicit operator Student(Teacher v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
