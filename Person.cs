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
        public State PatternMatching(State state, Transition transition)
        {
            return state=(state,transition)switch
            {
                (state.Running, Transition.Suspended) => State.Suspended,
                (state.Suspended, Transition.Resume) => State.Running,
                (state.Suspended, Transition.Terminate) => State.NotRunning,
                (state.NotRunning, Transition.Activate) => State.Running,
                _ => throw new InvalidOperationException()
            }
           
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
