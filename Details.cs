using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagaerApp
{
<<<<<<< HEAD
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
=======
    abstract class Details : IDetails
    {
        public void Address(string address)
        {
            throw new NotImplementedException();
        }

        public void Contact(double contact)
        {
            throw new NotImplementedException();
        }

        public void Email(string email)
        {
            throw new NotImplementedException();
        }
        public void Name(string firstName, string middleName, string LastName)
        {
            throw new NotImplementedException();
        }

        public void Post(string postName)
        {
            
        }
        
>>>>>>> 274242ba91cd921fafa476575da9e718da55e9e8
    }
}