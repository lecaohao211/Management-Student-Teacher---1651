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
        public int Salary { get; set; }
        public Teacher() { }
        public Teacher(int id, string name, string sex, int age, string phone, string subject, int yearExperience, int Salary, string email) : base(id,name,sex,age,phone)
        {
            Subject = subject;
            YearExperience = yearExperience;
            Email = email;
            this.Salary = Salary;
        }
        //Display teacher information
        public override void DisplayInfo()  
        {
            Console.WriteLine("=========TEACHER LIST=========");
            Console.WriteLine("Teacher ID:    " + ID);
            Console.WriteLine("Teacher Name:  " + Name);
            Console.WriteLine("Teacher Sex:   " + Sex);
            Console.WriteLine("Teacher Age:   " + Age);
            Console.WriteLine("Teacher Phone: " + Phone);
            Console.WriteLine("Teacher Subject: " + Subject);
            Console.WriteLine("Teacher Year of Experience: " + YearExperience);
            Console.Write("Salary: " + Salary + " Your salary is ");
            RattingSalary();
            Console.WriteLine("Teacher Email: " + Email);
            Console.WriteLine("===============================");
            Console.WriteLine("                               ");
        }
        ////Notification when adding students successfully
        public override void NotifyWhenAdded()
        {
            Console.WriteLine("Add Teacher Successfully!");
        }
        ////Notification when student update is successful
        public override void NotifyWhenupdated()
        {
            Console.WriteLine("Update Teacher Successfully!");
        }
        //Notice when deleting students successfully
        public override void NotifyWhenDeleted()
        {
            Console.WriteLine("Delete Teacehr Successfully!");
        }
        public void RattingSalary()
        {

            if (Salary > 0 && Salary <= 5)
            {
                Console.WriteLine("Low Lalary");
            }
           else if (Salary > 5 && Salary <= 10)
            {
                Console.WriteLine("Average Wage");
            }
            else
            {
                Console.WriteLine("High Salary");
            }
        }


    }


}
