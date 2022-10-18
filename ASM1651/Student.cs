using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    class Student : Person
    {
        public double Grade { get; set; }
        public string Classes { get; set; }
        public Student(string id, string name, string sex, int age, string phone, double grade, string classes) : base(id, name, sex, age, phone)
        {
            Grade = grade;
            Classes = classes;
        }

        public Student()
        {
        }

        public override void DisplayInfo()
        {
            //Console.WriteLine($"ID: {ID}, Name: {Name}, Sex: {Sex}, Age: {Age}, Phone: {Phone}, Grade: {Grade}, Class: {Classes}");
            Console.WriteLine("=========STUDENT LIST=========");
            Console.WriteLine("Student ID:    " + ID);
            Console.WriteLine("Student Name:  " + Name);
            Console.WriteLine("Student Sex:   " + Sex);
            Console.WriteLine("Student Age:   " + Age);
            Console.WriteLine("Student Phone: " + Phone);
            Console.WriteLine("Student Grade: " + Grade);
            Console.WriteLine("Student Class: " + Classes);
            Console.WriteLine("===============================");
            Console.WriteLine("                               ");
        }
        public override void NotifyWhenAdded()
        {
            Console.WriteLine("Add Student Successfully!");
        }
        public override void NotifyWhenupdated()
        {
            Console.WriteLine("Update Student Successfully!");
        }
        public override void NotifyWhenDeleted()
        {
            Console.WriteLine("Delete Student Successfully!");
        }

        public static implicit operator Student(Teacher v)
        {
            throw new NotImplementedException();
        }
    }
}
