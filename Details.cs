using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagaerApp
{
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
            throw new NotImplementedException();
        }
    }
}