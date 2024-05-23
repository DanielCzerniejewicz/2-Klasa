using System.Collections.Generic;
namespace ConsoleApplication1.Klasy
{
    public class Wierzcholek
    {
        public List<int> Polaczenia = new List<int>();

        public void DodajPolaczenie(int wierzcholek)
        {
            Polaczenia.Add(wierzcholek);
        }
    }
}