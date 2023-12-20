using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagaerApp
{
    public interface IDetails
    {
<<<<<<< HEAD
        int serialNumber {get; set;} 
=======
        void Name(string firstName, string middleName, string LastName);
        void Contact(double contact);
        void Email(string email);
        void Address(string address);
>>>>>>> 274242ba91cd921fafa476575da9e718da55e9e8
    }
}