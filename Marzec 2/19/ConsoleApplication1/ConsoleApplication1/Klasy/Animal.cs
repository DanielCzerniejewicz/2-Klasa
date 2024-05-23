using System;

namespace ConsoleApplication1.Klasy
{
    public class Animal
    {
        public enum Rodzaj
        {
            Ssak,
            Ptak,
            Gad,
            Ryba,
        }

        public int ID { get; set; }
        public string Imie { get; set; }
        public int Wiek { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public Rodzaj RodzajZwierzecia { get; set; }

        public Animal()
        {
            ID = 0;
            Imie = "Brak";
            Wiek = 0;
            DataUrodzenia = DateTime.MinValue;
            RodzajZwierzecia = Rodzaj.Ssak;
        }
    }
}