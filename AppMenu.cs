// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

<<<<<<< HEAD
using System.Data;
// See https://aka.ms/new-console-template for more inform

using TaskManagaerApp;
public class AppMenu
{
    
public void options()
        {
            Console.WriteLine("Enter 0 to Exit: ");
            Console.WriteLine("Enter 1 to Add Task: ");
            Console.WriteLine("Enter 2 to Add Student: ");
            Console.WriteLine("Enter 3 to assign Task:");
            Console.WriteLine("Enter 4 to List Task:");
            Console.WriteLine("Enter 5 to List Tasks assigned to Students:");
        }

public void Menu()
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
                        string nameOfTask = Console.ReadLine()!;
                        StudentTask.tasksDetails.Add(new TasksDetails());
                        Console.WriteLine("Input date of task: (yyyy, mm, dd)");
                        DateOnly date = DateOnly.Parse(Console.ReadLine()!);
                        StudentTask.tasksDetails.Add(new TasksDetails());
                        Console.WriteLine("New Task Successfully added.\nPress any Key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    break;
                    case 2:
                        Console.WriteLine("Fill the data below\nFirstname: ");
                        string firstName = Console.ReadLine()!;
                        StudentTask.tasksDetails.Add(new TasksDetails());
                        Console.WriteLine("LastName: ");
                        String lastName = Console.ReadLine()!;
                        StudentTask.studentInfo.Add(new Details());
                        Console.WriteLine("Contact: ");
                        var contact = Console.ReadLine()!;
                        StudentTask.studentInfo.Add(new Details());
                        Console.WriteLine("Email: ");
                        String email = Console.ReadLine()!;
                        StudentTask.studentInfo.Add(new Details());
                        Console.WriteLine("Student info added Successfully.\nPress any key to continue.");
                        Console.ReadKey();
                        Console.Clear();

                        break;                        
                    case 3:
                        Console.WriteLine("Select name: ");
                        List<Details> studentsinfo = new List<Details>();
                        var studentlist = studentsinfo.Select(c => c.StudentsNames).ToList();
                        foreach (var item in studentlist)
                        {
                            Console.WriteLine(item);
                        }
                        string chooseName = Console.ReadLine()!;
                        
                        
                        break;
                    case 4:
                        Console.WriteLine("These are the tasks: ");
                        List<TasksDetails> tasksDetails = new List<TasksDetails>();
                        var listStudentsTask = tasksDetails.Select(c => new TasksDetails()
                        {
                            taskName = c.taskName,
                            taskDate = c.taskDate
                        }).ToList();
                        Console.WriteLine("Press any key to close list.");
                        Console.ReadKey();
                        Console.Clear();
                    break;
                    case 5:
                        Console.WriteLine("Loading");
                    break;
                    
                    default:
                        Console.WriteLine("Unknown error");
                    break;
                }
                

            }
            }
        }
}
=======
// namespace TaskManagaerApp
// {
//     public class AppMenu
//     {
//         public void options()
//         {
//             Console.WriteLine("Enter 1 to Add Task: ");
//             Console.WriteLine("Enter 2 to Add Student: ");
//             Console.WriteLine("Enter 3 to assign Task:");
//             Console.WriteLine("Enter 4 to List Task:");
//             Console.WriteLine("Enter 5 to List Tasks assigned to Students:");
//         }
//         public void Menu()
//         {
//             bool exit = false;
//             while (!exit)
//             {
//                 Console.Clear();

//             }
//         }
//     }
// }
>>>>>>> 274242ba91cd921fafa476575da9e718da55e9e8
