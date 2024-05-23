using System;

namespace ConsoleApplication1.Klasy
{
    enum Rodzaj
    {
        Ssak,
        Gad,
        Plaz,
        Ptak,
        Ryba
    }
    internal class Animal
    {
        /*
         * Każde zwierzę powinno mieć następujące właściwości: nazwę, datę urodzenia,
         * informację czy jest ssakiem i rodzaj (ptak, ryba, gad, płaz lub ssak).
        Program powinien umożliwiać dodawanie nowych zwierząt do listy, podając ich właściwości od użytkownika.
        Program powinien umożliwiać wyświetlanie listy zwierząt z ich numerami i nazwami.
        Program powinien umożliwiać wyświetlanie szczegółów o wybranym zwierzęciu, takich jak opis, wiek i rodzaj.
        Program powinien umożliwiać usuwanie wszystkich lub pojedynczego zwierzęcia z listy.
        Program powinien mieć menu główne z opcjami do wyboru przez użytkownika.
        Program powinien być napisany zgodnie z konwencją nazewnictwa i formatowania kodu w C#.
         */
        public string Imie { get; set; }
        public bool CzySsak { get; set; }
        public DateTime Data_Urodzenia { get; set; }
        public Rodzaj Rodzaj { get; set; }

        public Animal(string imie, DateTime dataUrodzenia, bool czySsak, Rodzaj kind) : this(imie, dataUrodzenia,
            czySsak)
        {
            Rodzaj = kind;
        }
        public Animal(string imie, DateTime dataUrodzenia, bool czySsak): this(imie,dataUrodzenia)
        {
            CzySsak = czySsak;
        }
        public Animal(string imie, DateTime dataUrodzenia) : this(imie)
        {
            Data_Urodzenia = dataUrodzenia;
        }
        public Animal(string imie)
        {
            Imie = imie;
            CzySsak = true;
            Data_Urodzenia = DateTime.Now;
            Rodzaj = Rodzaj.Ssak;
        }

        //metoda opisujaca zwierzaka
        public string GetData()
        {
            string description =
                $"To jest {Imie}! Data Urodzenia : {Data_Urodzenia.ToShortDateString()} ";
            if (CzySsak == true)
            {
                description += "Zwierze jest ssakiem";
            }
            else
            {
                description += $"Zwierzę nie jest ssakiem jest : {Rodzaj}";
            }
            return description;
        }

        public void ShowAge()
        {
            Console.WriteLine($"{Imie} ma {DateTime.Now.Year - Data_Urodzenia.Year} lat");
        }
        
    }
}