using System;
using System.Collections.Generic;
//Zad.1
namespace Właściwy_SPR
{
    class Autobusy
    {
        public List<int> Busy = new List<int>();

        public void DodawanieLinii(List<int> l)
        {
            Console.WriteLine("Podaj numer Linii : ");
            int linia = int.Parse(Console.ReadLine());
            if (linia < 0)
            {
                Console.WriteLine("Jeszcze busa o linii ujemnej nie widzialem");
            }
            else
            {
                l.Add(linia);
            }
        }
        
    }
    class PunktCentralny : Autobusy
    {
        
    }
    class Przystanek : Autobusy
    {
        private List<Przystanek> ListaPrzystanków = new List<Przystanek>();
        public Przystanek Typ { get; set; }
        public bool CzyBiletomat { get; set; }
        public bool CzyZadaszenie { get; set; }
        public void ListaAutobusowDlaPrzystanku()
        {
            foreach (var element in Busy)
            {
                Console.WriteLine($"Linia nr : {element}");
            }
        }
    }

    class Pętla : Autobusy
    {
        
    }
    class Biletomat : Autobusy
    {
        
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
                 
        }
    }
}

namespace Zadanie2
{
    class Zadanie{}
    class Narzędzie{}
    interface Robotny
    {
        string Robota { get; set; }
        void planuj();
        void działaj(Zadanie z);
    }

    abstract class Rekin
    {
        private string imie;
        private string nazwisko;
        protected void dobierzNarzedzia(Narzędzie n)
        {
            
        }
    }

    class Leszcz
    {
        private string imie;
        private string odmiana;
        protected void wymyślajWymówki(){}
        private void czekaj(){}
        public void udawaj(){}
    }

    class Gracz
    {
        private string imie;
        private int poziom;
        protected void IdeGrać(){}
        private void jem(){}

        private bool wydalam()
        {
            return true;
            //Dalem returna by nie krzyczal błędem
        }

        protected char znówIdęGrać()
        {
            return 'r'; //return by nie krzyczal
        }

        class Klasa
        {
            public string NumerKlasy { get; set; }
            protected List<Robotny> ListaRobotnych { get; set; }
            public void dodajDoListy(){}
        }

        class Teknikum : Szkoła
        {
            private string nazwa;

            public string podajNazwe()
            {
                string Nazwa = "Nazwa";
                nazwa = Nazwa;
                return nazwa;
                //Dalem tu cos by nie krzyczal ze błąd
            }
        }
        
        class Szkoła
        {
            //Prywatny konstruktor tu nie ma sensu przy Teknikum dziedziczy po Szkole
            private string Kraj;
            public Szkoła(){}
            public void stwórzSzkołe(){}
        }
    }
}