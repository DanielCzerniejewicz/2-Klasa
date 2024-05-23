using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    internal class Machine
    {
        public string Name { get; set; }

        public Machine(string name)
        {
            Name = name;
            Console.WriteLine("Maszyna stworzona");
        }
        
        //Destruktor
        ~Machine()
        {
            Console.WriteLine($"{Name} Zniszczono!");
        }

        public Machine(Machine machine)
        {
            Name = machine.Name;
            Console.WriteLine("Kopia maszyny stworzona!");
        }

        public virtual void Start()
        {
            Console.WriteLine($"{Name} uruchomiony");
        }

        public void Stop()
        {
            Console.WriteLine($"{Name} wyłączony");
        }

        public virtual void Work()
        {
            Console.WriteLine($"{Name} pracuje!");
        }
    }

    internal class Excavator : Machine
    {
        public Excavator(string name) : base(name)
        {
            
        }

        public override void Start()
        {
            base.Start();
            Console.WriteLine($"{Name} rozpoczyna kopanie");
        }

        public void Stop(string powod)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Name} awaria! : {powod}");
            Console.ResetColor();;
        }
        
    }
    internal class Program
    {
        public static void Menu(List<Excavator> list)
        {
            Console.WriteLine("Podaj co robimy!");
            bool sprawdzacz = false;
            do
            {
                try
                {
                    Console.WriteLine("1.Wyswietl listę maszyn");
                    Console.WriteLine("2.Symuluj pracę maszyny");
                    string choice = Console.ReadLine();
                    switch (choice)
                    {
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            } while (!sprawdzacz);
        }
        public static void Main(string[] args)
        {
            Machine excavator = new Excavator("Koparka E-40");
            excavator.Start();
            ((Excavator)excavator).Stop("Silnik leży");
        }
    }
}