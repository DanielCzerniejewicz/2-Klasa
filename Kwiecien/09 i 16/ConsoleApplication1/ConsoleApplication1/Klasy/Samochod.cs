using System;
using System.Management.Instrumentation;

namespace ConsoleApplication1.Klasy
{
    internal class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public bool CzyUszkodzony { get; set; }
        
        public Samochod(string marka,string model)
        {
            Marka = marka;
            Model = model;
            CzyUszkodzony = false;
        }

        public void Jedz()
        {
            if (CzyUszkodzony == true)
            {
                Console.WriteLine($"Jadę samochodem {Marka} {Model}");
            }
            else
            {
                Console.WriteLine($"Awaria samochodu {Marka} {Model}!");
            }
        }

        public void LosoweUszkodzenie()
        {
            Random r = new Random();
            int uszkodzenie = r.Next(1, 4);
            if (uszkodzenie == 1)
            {
                Console.WriteLine($"{Marka} {Model} ma uszkodzony silnik!");
            }
            else if (uszkodzenie == 2)
            {
                Console.WriteLine($"{Marka} {Model} ma przebite opony!");
            }
            else
            {
                Console.Write($"{Marka} {Model} światła siadły!");
            }

            CzyUszkodzony = true;
        }

        ~Samochod()
        {
            Console.WriteLine($"{Model} {Marka} zezłomowany!");
        }
    }
    
}