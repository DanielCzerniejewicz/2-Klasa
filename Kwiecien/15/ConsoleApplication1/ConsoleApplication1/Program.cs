using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApplication1
{
    abstract class Wierzcholek
    {
        public string Nazwa;
        public abstract void wyswietl();
    }

    class Plik : Wierzcholek
    {
        public Plik(string name)
        {
            Nazwa = name;
        }

        public override void wyswietl()
        {
            Console.Write("---");
            Console.WriteLine(Nazwa);
        }
    }

    class Katalog : Wierzcholek
    {
        private List<Wierzcholek> wierzcholki = new List<Wierzcholek>();

        public Katalog(string n)
        {
            Nazwa = n;
        }

        public void dodaj(Wierzcholek w)
        {
            wierzcholki.Add(w);
        }

        public override void wyswietl()
        {
            Console.WriteLine(Nazwa);
            foreach (var element in wierzcholki)
            {
                Console.Write("--");
                element.wyswietl();
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Katalog d1 = new Katalog("Dysk");
            Katalog k1 = new Katalog("Zdjecia");
            Katalog k2 = new Katalog("Prace");
            Katalog k3 = new Katalog("Różne");
            Plik p1 = new Plik("fota1");
            k2.dodaj(p1);
            d1.dodaj(k1);
            d1.dodaj(k2);
            d1.dodaj(k3);
            d1.wyswietl();
        }
    }
}