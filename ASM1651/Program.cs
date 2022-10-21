using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1651
{
    internal class Program
    {
        static void Main(string[] args)
        {
            School green = new School();
            ShowMainMenu(green);

        }

        static void ShowMainMenu(School green)
        {
            
            // Main menu
            Console.WriteLine("===SCHOOL MANAGEMENT MENU===");
            Console.WriteLine("===============================");
            Console.WriteLine("1. Manage Students");
            Console.WriteLine("2. Manage Teachers");
            Console.WriteLine("3. Exit");
            Console.WriteLine("===============================");
            // User choose
            Console.Write("Please choose: ");
            string userChoose = String.Empty;
            userChoose = Console.ReadLine();

            switch (userChoose)
            {
                case "1":
                    // Show menu Student Management
                    ShowMenuStudentManagement(green);
                    break;
                case "2":
                    // Show menu Lecturer Management
                    ShowMenuTeacherManagement(green);
                    break;
                case "3":
                    // Exit program
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not correct command. Please input only number (1, 2 or 3)");
                    ShowMainMenu(green);
                    break;
            }
        }


        static void ShowMenuStudentManagement(School green)
        {
            string userChoose = String.Empty;
            do
            {
                // Sub menu Student Management
                Console.WriteLine("====STUDENT MANAGEMENT MENU====");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Add new Student");
                Console.WriteLine("2. View all Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Back to main menu");
                Console.WriteLine("===============================");
                Console.WriteLine("                               ");

                // User choose
                Console.Write("Please choose: ");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "1": 
                        green.AddStudent();
                        break;
                    case "2":
                        green.ShowStudent();
                        break;
                    case "3":
                        green.UpdateStudent();
                        break;
                    case "4":
                        green.DeleteStudent();
                        break;
                    case "5":
                        ShowMainMenu(green);
                        break;
                    default:
                        Console.WriteLine("Not correct command. Please input only number (1, 2, 3, 4 or 5)");
                        ShowMenuStudentManagement(green);
                        break;
                }
            } while (userChoose != "5");
        }


        static void ShowMenuTeacherManagement(School green)
        {
            string userChoose = String.Empty;
            do
            {
                // Sub menu Lecturer Management
                Console.WriteLine("====TEACHER MANAGEMENT MENU===");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Add new teacher");
                Console.WriteLine("2. View all teachers");
                Console.WriteLine("3. Update teacher");
                Console.WriteLine("4. Delete teacher");
                Console.WriteLine("5. Back to main menu");
                Console.WriteLine("===============================");

                // User choose
                Console.Write("Please choose: ");
                userChoose = Console.ReadLine();

                switch (userChoose)
                {
                    case "1":
                        green.AddTeacher();
                        break;
                    case "2": 
                        green.ShowTeacher();
                        break;
                    case "3":
                        green.UpdateTeacher();
                        break;
                    case "4":
                        green.DeleteTeacher();
                        break;
                    case "5": 
                        ShowMainMenu(green);
                        break;
                    default:
                        Console.WriteLine("Not correct command. Please input only number (1, 2, 3, 4 or 5)");
                        ShowMenuStudentManagement(green);
                        break;
                }
            } while (userChoose != "5");
        }


    }
}
