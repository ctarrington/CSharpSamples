﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Person
    {        
        public string FirstName { get; private set; }
        public string LastName  { get; private set; }        

        public Person(string firstName = "John", string lastName = "Doe")
        {
            // TODO: Complete member initialization
            this.FirstName = firstName;
            this.LastName = lastName;
        }        
    }
}
