using System;
using System.Collections.Generic;
using ConsoleApplication2.Klasy;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Samochody> samochodziki = new List<Samochody>();
            Menu(samochodziki);
        }

        public static void DodajSamochod(List<Samochody> lista)
        {
            Console.Clear();
            Console.WriteLine("Podaj ilość kół: ");
            int ilosc = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Rok Produkcji: ");
            int RP = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Model: ");
            string Model = Console.ReadLine();
            Console.WriteLine("Podaj Markę: ");
            string Marka = Console.ReadLine();
            Console.WriteLine("Data 1. Rejestracji: ");
            DateTime Rejestra = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Podaj pojemność Silnika: ");
            float pojemnosc = float.Parse(Console.ReadLine());

            Samochody a = new Samochody(RP, Model, Marka, Rejestra, ilosc, pojemnosc);
            lista.Add(a);
            Console.WriteLine("Samochód został dodany.");
            Console.WriteLine("Naciśnij Enter, aby wrócić do menu.");
            Console.ReadLine();
            Menu(lista);
        }

        public static void Menu(List<Samochody> lista)
        {
            Console.Clear();
            Console.WriteLine("Wybierz opcję : ");
            Console.WriteLine("1. Dodaj samochód");
            Console.WriteLine("2. Wyświetl Informacje");
            Console.WriteLine("3. Oblicz Wiek Samochodu");
            Console.WriteLine("4. Sprawdź, czy klasyk");
            Console.WriteLine("5. Wyswietlanie Operacji JSON");
            Console.WriteLine("6. Oblicz Spalanie");
            Console.WriteLine("7. Wyjdz");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    DodajSamochod(lista);
                    break;
                case "2":
                    Samochody.WyswietlInformacje(lista);
                    Console.WriteLine("Naciśnij Enter, aby wrócić do menu.");
                    Console.ReadLine();
                    Menu(lista);
                    break;
                case "3":
                    Samochody.ObliczWiek(lista);
                    Console.WriteLine("Naciśnij Enter, aby wrócić do menu.");
                    Console.ReadLine();
                    Menu(lista);
                    break;
                case "4":
                    Samochody.CzyKlasyk(lista);
                    Console.WriteLine("Naciśnij Enter, aby wrócić do menu.");
                    Console.ReadLine();
                    Menu(lista);
                    break;
                case "5":
                    Console.WriteLine("JSON'a nie było (na 90%)");
                    Console.WriteLine("Naciśnij Enter, aby wrócić do menu.");
                    Console.ReadLine();
                    Menu(lista);
                    break;
                case "6":
                    Samochody.ObliczSpalanie(lista);
                    Console.WriteLine("Naciśnij Enter, aby wrócić do menu.");
                    Console.ReadLine();
                    Menu(lista);
                    break;
                case "7":
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór. Wybierz ponownie.");
                    Console.WriteLine("Naciśnij Enter, aby kontynuować.");
                    Console.ReadLine();
                    Menu(lista);
                    break;
            }
        }
    }
}
