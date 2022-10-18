using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASM1651
{
    class Teacher : Person, ISalary
    {
        public string Subject { get; set; }
        public int YearExperience { get; set; }
        public string Email { get; set; }
        public int salary { get ; set ; }
        public Teacher() { }

        public Teacher(string id, string name, string sex, int age, string phone, string subject, int yearExperience, string email) : base(id,name,sex,age,phone)
        {
            Subject = subject;
            YearExperience = yearExperience;
            Email = email;

        }
        public override void DisplayInfo()
        {
            //Console.WriteLine($"ID: {ID}, Name: {Name}, Sex: {Sex}, Age: {Age}, Phone: {Phone}, Subject: {Subject}, Year Experience: {YearExperience}, Emai: {Email}");
            Console.WriteLine("=========STUDENT LIST=========");
            Console.WriteLine("Teacher ID:    " + ID);
            Console.WriteLine("Teacher Name:  " + Name);
            Console.WriteLine("Teacher Sex:   " + Sex);
            Console.WriteLine("Teacher Age:   " + Age);
            Console.WriteLine("Teacher Phone: " + Phone);
            Console.WriteLine("Teacher Subject: " + Subject);
            Console.WriteLine("Teacher Year of Experience: " + YearExperience);
            Console.WriteLine("Teacher Email: " + Email);
            Console.WriteLine("===============================");
            Console.WriteLine("                               ");
        }
        public override void NotifyWhenAdded()
        {
            Console.WriteLine("Add Teacher Successfully!");
        }
        public override void NotifyWhenupdated()
        {
            Console.WriteLine("Update Teacher Successfully!");
        }
        public override void NotifyWhenDeleted()
        {
            Console.WriteLine("Delete Teacehr Successfully!");
        }

        public void RattingSalary()
        {
            
        }
    }
}
