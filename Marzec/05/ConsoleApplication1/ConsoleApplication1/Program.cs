using System;
using System.Collections.Generic;
using ConsoleApplication1.Klasy;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Animal a = new Animal("Burek");
            Console.WriteLine(a.GetData());
            a.Data_Urodzenia = new DateTime(2014, 2, 3);
            a.ShowAge();
            //Tworzenie Listy zwierząt
            List<Animal> zwierzaki = new List<Animal>();
        }
        
        static void ShowMainMenu(List<Animal> animals)
        {
            Console.Clear();

            Console.WriteLine("Witaj w programie do zarządzania zwierzętami");
            Console.WriteLine("Wybierz jedną z opcji : ");
            Console.WriteLine("1. Dodaj zwierzę");
            Console.WriteLine("2. Pokaż Listę zwierząt");
            Console.WriteLine("3. Pokaż listę zwierząt");
            Console.WriteLine("4. Usuń zwierze");
            Console.WriteLine("5. Zakończ Program");
            string wybor = Console.ReadLine();
            switch (wybor)
            {
                case "1":
                    
                    break;
            }
        }
    }
    
}