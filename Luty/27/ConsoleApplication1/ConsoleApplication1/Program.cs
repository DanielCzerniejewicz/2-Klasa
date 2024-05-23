using System;
using ConsoleApplication1.Klasy;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person("Janusz");
            Person person2 = new Person("Anna");
            Person person3 = new Person();
            Person person4 = new Person("Paweł","Kowal");
            //wyswietlenie ile jest obiektow w klasie person
            Console.WriteLine(Person.Counter);
            Console.WriteLine($"Obiekt person1 : {person1.GetData()}");
            //Wyswietlenie wartosci domyslnych
            Console.WriteLine($"Obiekt person3: {person3.GetData()}");
        }
    }
}