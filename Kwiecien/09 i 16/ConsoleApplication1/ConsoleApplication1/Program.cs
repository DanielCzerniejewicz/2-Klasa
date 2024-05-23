using System;
using System.Collections.Generic;
using ConsoleApplication1.Klasy;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Samochod> auta = new List<Samochod>();
            Dictionary<int, Samochod> autaSlownik = new Dictionary<int, Samochod>();

            bool flaga = true;   
            while (flaga)
            {
                Console.WriteLine("Menu symulatora jazdy samochodem");
                Console.WriteLine("1. Dodaj samochód");
                Console.WriteLine("2. Wyświetl listę samochodów");
                Console.WriteLine("3. Jedź samochodem");
                Console.WriteLine("4. Symuluj uszkodzenia");
                Console.WriteLine("5. Zezłomuj samochód");
                Console.WriteLine("6. Wyjście");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Podaj markę samochodu!");
                        string marka = Console.ReadLine();
                        Console.WriteLine("Podaj model samochodu!");
                        string model = Console.ReadLine();
                        Samochod car = new Samochod(marka, model);
                        auta.Add(car);
                        autaSlownik[auta.Count] = car;
                        Console.WriteLine("Samochód dodany pomyślnie!");
                        break;
                    case 2:
                        Console.WriteLine("Lista samochodów : ");
                        foreach (var element in auta)
                        {
                            Console.WriteLine(element.Marka + " " + element.Model);
                            Console.WriteLine();
                        }

                        break;
                    case 3:
                        Console.WriteLine("Jazda autem!");
                        Console.WriteLine("Podaj numer samochodu do jazdy : ");
                        int numer = int.Parse(Console.ReadLine());
                        if (autaSlownik.TryGetValue(numer, out Samochod wybrany))
                        {
                            wybrany.Jedz();
                        }
                        else
                        {
                            Console.WriteLine("Nie prawidlowy numer auta!");
                        }

                        break;
                    case 4:
                        Console.WriteLine("Podaj numer samochodu do symulacji uszkodzenia!");
                        int numerUszkodzonegoAuta = int.Parse(Console.ReadLine());
                        if (autaSlownik.TryGetValue(numerUszkodzonegoAuta, out Samochod uszkodzenie))
                        {
                            uszkodzenie.LosoweUszkodzenie();
                        }
                        else
                        {
                            Console.WriteLine("Nie prawidłowy numer!");
                        }

                        break;
                    case 5:
                        Console.WriteLine("Podaj numer auta do zezlomowania!");
                        int numerAuta = int.Parse(Console.ReadLine());
                        if (autaSlownik.TryGetValue(numerAuta, out Samochod samochod))
                        {
                            //Wywolanie destruktora ktory usuwa obiekt
                            samochod = null;
                            GC.Collect();
                        }
                        else
                        {
                            Console.WriteLine("Błędny numer!");
                        }

                        break;
                    case 6:
                        Console.WriteLine("Zamykanie symulatora");
                        flaga = false;
                        break;
                    default:
                        Console.WriteLine("Błędny numer!");
                        break;
                }
            }
        }
    }
}