using System;

namespace ConsoleApplication1.Classes
{
    enum Gender
    
    {
        mężczyzna,
        kobieta
    }
    public class Person
    {
        public string FirstName { get; private set; }
        public Adress Adress { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Plec { get; set; }

        public Person()
        {
            Adress = new Adress();
        }

        public Person(string firstName, DateTime dateOfBirth, Gender plec)
        {
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Płeć = płeć;
            Adress = new Adress();
        }

        public void SetFirstName(string name)
        {
            FirstName = name;
        }

        public string GetData()
        {
            return $"Imię: {FirstName}, Data urodzenia: {DateOfBirth}, Płeć: {Płeć}";
        }
    }
}