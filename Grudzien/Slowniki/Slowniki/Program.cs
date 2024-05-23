using System;
using System.Collections.Generic;

namespace Slowniki
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik,
            // w którym kluczem jest liczba, a wartością jest jej częstotliwość występowania na liście.
            //     Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
            //     Przykład: dla listy [1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik {1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
            // Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za
            //  pomocą metody TryParse, a następnie wyświetla wynik na konsoli.
            //     Jeśli konwersja się powiedzie, program powinien wyświetlić
            // liczbę i informację, że jest to poprawna liczba całkowita.
            //     Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację,
            // że podany ciąg znaków nie jest poprawną liczbą całkowitą.
            //     Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
            // Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.
        }

        public static Dictionary<int,int> ReturnDictionary(List<int> list)
        {
            Dictionary<int,int> dict = new Dictionary<int,int>();
            if (list.Count == null)
            {
                return dict;
            }

            int pomocnicza = 0;
            foreach (var element in list)
            {
                pomocnicza = 0;
                foreach (var czestotliwosc in list)
                {
                    
                    if (element == czestotliwosc)
                    {
                        pomocnicza++;
                    }
                }
                dict.Add(element,pomocnicza);
            }

            return dict;
        }

        public static void ciagi(string ciag)
        {
            int liczba = 0;
            for(int i = 0; i<ciag.Length;i++)
            {
                if(int.TryParse(ciag[i].ToString(),out liczba))
                {
                    Console.WriteLine($"{ciag[i]} jest liczbą");
                }
                else
                {
                    Console.WriteLine($"{ciag[i]} nie jest liczbą");
                }
            }
        }
    }
}