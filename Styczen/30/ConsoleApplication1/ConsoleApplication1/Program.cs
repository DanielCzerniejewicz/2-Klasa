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
            
        }

    }
}