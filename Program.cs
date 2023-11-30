using System.Threading.Tasks;
using System.Reflection.Emit;
using System.Data;
using Internal;
using System;
// See https://aka.ms/new-console-template for more inform

using TaskManagaerApp;
void options()
        {
            Console.WriteLine("Enter 0 to Exit: ");
            Console.WriteLine("Enter 1 to Add Task: ");
            Console.WriteLine("Enter 2 to Add Student: ");
            Console.WriteLine("Enter 3 to assign Task:");
            Console.WriteLine("Enter 4 to List Task:");
            Console.WriteLine("Enter 5 to List Tasks assigned to Students:");
        }
void Menu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
            options();
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                switch (input)
                {
                    case 0:
                        exit = true;
                    break;
                    case 1:
                        Console.WriteLine("Input task name: ");
                        string taskName = Console.ReadLine();
                    break;
                    case 2:
                        Console.WriteLine("Fill the data below\nFirstname: ");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("LastName: ");
                        String lastName = Console.ReadLine();
                        Console.WriteLine("MiddleName: ");
                        String middleName = Console.ReadLine();
                        Console.WriteLine("Contact: ");
                        var contact = Console.ReadLine();
                        Console.WriteLine("Email: ");
                        String email = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Coming Soon :)");
                        break;
                    case 4:
                        Console.WriteLine(Task.taskname());
                    break;
                    default:
                        Console.WriteLine("oK");
                    break;
                }
                

            }
            }
        }
Menu();

