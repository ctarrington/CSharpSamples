using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OldFeaturesAndTests
{
    class Person
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public Person(string firstName = "John", string lastName = "Doe")
        {
            // TODO: Complete member initialization
            this._firstName = firstName;
            this._lastName = lastName;
        }        
    }
}
