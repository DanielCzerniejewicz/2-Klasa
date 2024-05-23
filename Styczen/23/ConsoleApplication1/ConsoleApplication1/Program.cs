using System;
using System.Collections.Generic;
using ConsoleApplication1.Classes;

namespace ConsoleApplication1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person osoba = new Person();
            osoba.SetFirstName("Nowakos");
            Console.WriteLine("Nazwisko : " + osoba.FirstName);
            Student studenciak = new Student();
            studenciak.Student_ID = "1";
            Console.WriteLine("ID Studenta : " +studenciak.Student_ID);
            Teacher nauczyciel = new Teacher();
            nauczyciel.Subjects = new List<string>() {"Majca","Infa"};
            nauczyciel.GetList();
            osoba.Adress = new Adress();
            osoba.Adress.City = "Poznan";
            osoba.Adress.Street = "Ulica";
            osoba.DateOfBirth = DateTime.Now;
            Person p1 = new Person();
            p1.Adress = new Adress();
            p1.Płeć = Płeć.mężczyzna;
            p1.DateOfBirth = new DateTime(2000, 1, 5, 9, 14, 22);
            p1.SetFirstName("Hanzo");
            p1.Adress.City = "Earth Realm";
            p1.Adress.Street = "Fire Garden";
            p1.Adress.HouseNumber = "52";
            p1.Adress.PostalCode = "21-421";
            Console.WriteLine(p1.GetAdress());
            Console.WriteLine(p1.GetData());
            

        }

    }
}