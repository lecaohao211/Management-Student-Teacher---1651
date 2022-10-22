using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    abstract class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Person(int id, string name, string sex, int age, string phone)
        {
            ID = id;
            Name = name;
            Sex = sex;
            Age = age;
            Phone = phone;
        }
        public Person()
        {
        }   
        public virtual void DisplayInfo() 
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Sex: {Sex}, Age: {Age}, Phone: {Phone}");
        }
        public virtual void NotifyWhenAdded()
        {
            Console.WriteLine("Add successfully");
        }
        public virtual void NotifyWhenupdated()
        {
            Console.WriteLine("Update successfully");
        }
        public virtual void NotifyWhenDeleted()
        {
            Console.WriteLine("Delete successfully");
        }



    }
}
