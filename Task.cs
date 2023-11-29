using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TaskManagaerApp
{
    public class Task
    {
        List<string> taskName = new();
        public DateTime dueDate = new DateTime(2024, 7, 31);
        public string Priority = Console.ReadLine()!;
    }    
}