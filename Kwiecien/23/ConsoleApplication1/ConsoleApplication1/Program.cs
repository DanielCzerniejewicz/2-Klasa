using System;

namespace ConsoleApplication1
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public double Fuel { get; set; }

        public virtual void StartEngine()
        {
            Console.WriteLine("`\nSilnik Uruchomiony!");
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}