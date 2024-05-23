using System;
using System.Collections.Generic;

namespace ConsoleApplication2.Klasy
{
    enum RodzajPaliwka
    {
        Benzyna,
        Diesel,
        Elektryczny,
        Hybrydowy,
    }
    public class Samochody
    {
        public int IloscKol { get; set; }
        private string Marka { get; set; }
        private string Model { get; set; }
        private int RokProdukcji { get; set; }
        public DateTime DataPierwszejRejestracji { get; set; }
        public float PojemnoscSilnika { get; set; }
        public Samochody()
        {
            RokProdukcji = 0;
            Marka = "Nieznany";
            Model = "Nieznany";
        }
        public Samochody(int rokProdukcji, string model, string marka, DateTime dataPierwszejRejestracji, int iloscKol, float pojemnoscSilnika)
        {
            RokProdukcji = rokProdukcji;
            Model = model;
            Marka = marka;
            DataPierwszejRejestracji = dataPierwszejRejestracji;
            PojemnoscSilnika = pojemnoscSilnika;
            IloscKol = iloscKol;
        }

        public static void WyswietlInformacje(List<Samochody> lista)
        {
            Console.Clear();
            if (lista.Count == 0)
            {
                Console.WriteLine("Pusta Lista");
            }
            else
            {
                foreach (var element in lista)
                {
                    Console.WriteLine($"{element.RokProdukcji} , {element.Model}, {element.Marka},{element.DataPierwszejRejestracji},{element.IloscKol},{element.PojemnoscSilnika}");
                }
            }
            Program.Menu(lista);
        }


        public static void ObliczWiek(List<Samochody> lista)
        {
            Console.Clear();
            WyswietlInformacje(lista);
            Console.WriteLine("Podaj numer auta, którego wiek chcesz obliczyć : ");
            int numer = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Wiek samochodu: {DateTime.Now.Year - lista[numer].RokProdukcji} lat");
            Program.Menu(lista);
        }

        public void ZmienMarkeIModel(List<Samochody> lista)
        {
            WyswietlInformacje(lista);
            Console.WriteLine("Podaj numer samochodu, którego markę i model chcesz zmienić: ");
            int numer = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Podaj nową markę: ");
            string nowaMarka = Console.ReadLine();
            Console.WriteLine("Podaj nowy model: ");
            string nowyModel = Console.ReadLine();
            lista[numer].Marka = nowaMarka;
            lista[numer].Model = nowyModel;
            Console.WriteLine("Marka i model samochodu zostały zmienione.");
            Program.Menu(lista);
        }

        public static bool CzyKlasyk(List<Samochody> lista)
        {
            WyswietlInformacje(lista);
            Console.WriteLine("Podaj numer samochodu, którego klasykowość chcesz sprawdzić: ");
            int numer = int.Parse(Console.ReadLine()) - 1;
            if (DateTime.Now.Year - lista[numer].RokProdukcji >= 25)
            {
                Console.WriteLine("Samochód jest klasykiem.");
                return true;
            }
            else
            {
                Console.WriteLine("Samochód nie jest klasykiem.");
                return false;
            }
        }

        public static void ObliczSpalanie(List<Samochody> lista)
        {
            Console.Clear();
            Console.WriteLine("Podaj ilość przejechanych kilometrów: ");
            float przejechaneKM = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj zużyte paliwo: ");
            float zuzytePaliwo = float.Parse(Console.ReadLine());
            Console.WriteLine($"Spalanie: {(zuzytePaliwo / przejechaneKM) * 100} litrów na 100 kilometrów.");
            Console.ReadKey();
            Program.Menu(lista);
        }
    }
}
