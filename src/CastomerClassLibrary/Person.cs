using System;
using System.Collections.Generic;


namespace CastomerClassLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string lastName)
        {
            LastName = lastName;
        }
    }
}
