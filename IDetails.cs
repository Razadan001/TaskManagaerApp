using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagaerApp
{
    public interface IDetails
    {
        void Name(string firstName, string middleName, string LastName);
        void Post(string postName);
        void Contact(double contact);
        void Email(string email);
        void Address(string address);
    }
}