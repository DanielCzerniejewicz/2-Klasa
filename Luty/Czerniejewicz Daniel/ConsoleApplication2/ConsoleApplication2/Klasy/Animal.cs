using System;

namespace ConsoleApplication2.Klasy
{
    public class Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Color { get; set; }
        public ushort Age { get; set; }
        public float Weight { get; set; }
        public Person Owner { get; set; }

        public string GetInfo()
        {
            return $"Name: {Name} , Species: {Species}, Color: {Color}, Age: {Age}, Weight: {Weight}, Owner: {Owner.Imie} {Owner.Nazwisko}, Date Of Birth : {Owner.DataUrodzenia}";
        }
    }
}