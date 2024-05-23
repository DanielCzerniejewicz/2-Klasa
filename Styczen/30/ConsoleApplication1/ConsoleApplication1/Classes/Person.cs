using System;

namespace ConsoleApplication1.Classes
{
    class Person
        {
            public string FirstName { get;private set; }
            public Adress Adress { get; set; }
            public DateTime DateOfBirth { get; set; }

            public void SetFirstName(string Name)
            {
                FirstName = Name;
            }
        }
}