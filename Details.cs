using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagaerApp
{
    public class Details : IDetails
    {
        public void AddTask(string name)
        {
            var taskname = StudentTask.tasksDetails;
        }

        public int serialNumber {get; set;} = default;

        public double Contact { get; set;}

        public string? Email { get; set; }
        public string? StudentsNames {get; set; }
    }
}