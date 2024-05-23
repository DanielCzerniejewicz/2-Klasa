namespace ConsoleApplication1
{
    class User
    {
        
    }

    class Aktywność
    {
        private string typ;
        public string czas;
    }

    class Adres
    {
        public string ulica;
        public string kod;
        public string miasto;
    }

    class Pracownik : User
    {
        private string stanowisko;
        protected string wyplata;
        Aktywność Aktywność;
        Adres Adres;

        public void setAktywnosc(Aktywność aktywnosc)
        {
            Aktywność = aktywnosc;
        }

        public void DodawanieAdresu(Adres adres)
        {
            Adres = adres;
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            
        }
    }
}