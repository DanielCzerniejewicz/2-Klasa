using System;
using ConsoleApplication1.Klasy;
namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Graf g = new Graf(7);
            g.DodajKrawedz(0, new int[] {2});
            g.DodajKrawedz(1, new int[] {3,4});
            g.DodajKrawedz(2, new int[] {0,4});
            g.DodajKrawedz(3, new int[] {1,6});
            g.DodajKrawedz(4, new int[] {1,2,6});
            g.DodajKrawedz(6, new int[] {3,4});
            for (int i = 0; i < 7; i++)
            {
                foreach (var item in g.Wierzcholki)
                {
                    foreach (var element in item.Polaczenia)
                    {
                        Console.Write("{0} - {1}",i,element);
                    }
                    
                }

                Console.WriteLine();
            }
        }
    }
}