using System.Collections.Generic;
using ZadankoZKlas.Klasy;
namespace ZadankoZKlas.Klasy
{
    internal class Zamowienia
    {
        Klient k;
        List<Produkt> p;
        Dostawy d;

        public void SetKlient(Klient k)
        {
            this.k = k;
        }

        public void SetProdukt(Produkt p)
        {
            this.p.Add(p);
        }

        public void JednakDodajDostawę(Dostawy d)
        {
            this.d = d;
        }
    }
}