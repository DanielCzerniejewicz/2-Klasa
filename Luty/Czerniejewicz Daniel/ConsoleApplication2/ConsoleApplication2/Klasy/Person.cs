using System;
using System.Collections.Generic;

namespace ConsoleApplication2.Klasy
{
    public class Person
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public List<string> imiona_zwierząt { get; set; }

        public void PrintowanieZwierzat(List<string> imiona)
        {
            foreach (var element in imiona)
            {
                Console.Write(element + " ");
            }
        }
    }
}