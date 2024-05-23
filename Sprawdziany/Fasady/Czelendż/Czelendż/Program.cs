using System;
using System.Collections.Generic;
using System.IO;

namespace Czelendż
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Zad. 3.1");
            string path = @"C:\Users\Daniel\Desktop\Szkola\2Klasa\POPr\Sprawdziany\Fasady\Czelendż\Czelendż\Properties\anagram.txt";

            List<string> Plik = new List<string>();
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream) { 
                string line = sr.ReadLine(); 
                Plik.Add(line);
            }

            int binar_zrow = 0;
            int binar_prawie = 0;

            foreach (string line in Plik)
            {
                int suma1 = 0;
                int suma0 = 0;

                foreach (char c in line)
                {
                    if (c == '1')
                    {
                        suma1 += 1;
                    }
                    else
                    {
                        suma0 += 1;
                    }
                }

                if (suma1 == suma0)
                {
                    binar_zrow++;
                }

                if (Math.Abs(suma1 - suma0) == 1)
                {
                    binar_prawie++;
                }
            }

            Console.WriteLine($"Zrownowarzone : {binar_zrow}");
            Console.WriteLine($"Prawie zrownowazone : {binar_prawie}");
            Console.WriteLine("Zad.2 ,3.2");

            for (int i = 0; i < Plik.Count; i++)
            {
                string wynik = "";
                string liczba = Plik[i];
                for (int j = 1; j <= liczba.Length; j++)
                {
                    wynik = liczba[j] + " ";
                }
            }
        }
    }
}