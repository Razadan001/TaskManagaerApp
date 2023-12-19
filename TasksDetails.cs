using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagaerApp
{
    public class TasksDetails
    {
        public string? taskName {get;set;}

        public DateOnly taskDate {get;set;} = new DateOnly();
    }
}