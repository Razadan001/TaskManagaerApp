using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TaskManagaerApp
{
    public class Task
    {
        public string[] taskName = {"Governor", "Deputy Governor", "Chief Imam", "Chef1", "Chef2", "Chef3", "Chef4"};
        public DateTime dueDate = new DateTime(2024, 7, 31);
        public string Priority = Console.ReadLine()!;
    }    
}