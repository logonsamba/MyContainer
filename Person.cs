using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp8Features
{
    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        Person(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
        
    }
    public enum State
    {
        Running,
        Suspended,
        NotRunning
    }
    public enum Transition
    {
        Running,
        Suspended,
        NotRunning
    }
}
