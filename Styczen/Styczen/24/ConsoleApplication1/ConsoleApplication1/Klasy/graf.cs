using System.Collections.Generic;
namespace ConsoleApplication1.Klasy
{
    public class Graf
    {
        public List<Wierzcholek> Wierzcholki = new List<Wierzcholek>();

        public Graf(int ilośćWierchołków)
        {
            for(int i = 0; i < ilośćWierchołków; i++)
            {
                Wierzcholki.Add(new Wierzcholek());
            }
        }

        public void DodajKrawedz(int wierzchołek, int[] połączenia)
        {
            foreach (var element in połączenia)
            {
                Wierzcholki[wierzchołek].DodajPolaczenie(element);
                
            }
        }
        
    }
}