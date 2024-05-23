using System;
using System.Collections.Generic;
using ConsoleApplication1.Klasy;

namespace ConsoleApplication1
{
  internal class Program
  {
    public static void Main(string[] args)
    { 
      List<Animal> zwierzaki = new List<Animal>();
      Menu(zwierzaki);
    }

    public static void Menu(List<Animal> animals)
    {
      Console.Clear();
      Console.WriteLine("Wybierz : ");
      Console.WriteLine("1.Informacje o zwierzakach");
      Console.WriteLine("2.Dodaj zwierzaka");
      Console.WriteLine("3.Usun Zwierzaka");
      Console.WriteLine("4.Czy Ssak");
      Console.WriteLine("5.Wyjdz");
      string choice = Console.ReadLine();
      switch (choice)
      {
        case "1":
          PokazListe(animals);
          break;
        case "2":
          DodajZwierzaka(animals);
          break;
        case "3":
          Usuwanie(animals);
          break;
        case "4":
          CzySsak(animals);
          break;
        case "5":
          break;
        default:
          Menu(animals);
          break;
      }
    }

    public static void DodajZwierzaka(List<Animal> zwierzaki)
    {
      Console.Clear();
      Animal a = new Animal();
      Console.Clear();
      Console.WriteLine("Podaj ID : ");
      a.ID = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj Imię : ");
      a.Imie = Console.ReadLine();
      Console.WriteLine("Podaj Wiek : ");
      a.Wiek = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj Datę Urodzenia : ");
      a.DataUrodzenia = DateTime.Parse(Console.ReadLine());
      Console.WriteLine("Podaj Gatunek [Ssak,Ptak,Gad,Ryba] : ");
      a.RodzajZwierzecia = (Animal.Rodzaj)Enum.Parse(typeof(Animal.Rodzaj), Console.ReadLine());
      zwierzaki.Add(a);
      Menu(zwierzaki);
    }

    public static void PokazListe(List<Animal> zwierzaki)
    {
      Console.Clear();
      if (zwierzaki.Count == 0)
      {
        Console.WriteLine("Pusta Lista. Wciśnij cokolwiek, aby kontynuować.");
        Console.ReadKey();
        Menu(zwierzaki);
      }
      else
      {
        foreach (var element in zwierzaki)
        {
          Console.WriteLine($"ID: {element.ID}, Imię: {element.Imie}, Wiek: {element.Wiek}, Data Urodzenia: {element.DataUrodzenia}, Rodzaj : {element.RodzajZwierzecia}");
        }
        Console.WriteLine("Wciśnij cokolwiek, aby kontynuować.");
        Console.ReadKey();
        Menu(zwierzaki);
      }
    }

    public static void Usuwanie(List<Animal> zwierzaki)
    {
      Console.Clear();
      if (zwierzaki.Count == 0)
      {
        Console.WriteLine("Pusta Lista. Wciśnij cokolwiek, aby kontynuować.");
        Console.ReadKey();
        Menu(zwierzaki);
      }
      else
      {
        foreach (var element in zwierzaki)
        {
          Console.WriteLine(
            $"ID: {element.ID}, Imię: {element.Imie}, Wiek: {element.Wiek}, Data Urodzenia: {element.DataUrodzenia}, Rodzaj : {element.RodzajZwierzecia}");
        }
      }

      Console.WriteLine();
      Console.WriteLine("1.Czyscimy całą listę");
      Console.WriteLine("2.Usuwamy zwierzaka");
      string choice = Console.ReadLine();
      switch (choice)
      {
        case "1":
          zwierzaki.Clear();
          Menu(zwierzaki);
          break;
        case "2":
          Console.WriteLine("Podaj ID zwierzaka : ");
          int ID = int.Parse(Console.ReadLine());
          zwierzaki.Remove(zwierzaki[ID-1]);
          Menu(zwierzaki);
          break;
        default:
          Usuwanie(zwierzaki);
          break;
      }
    }

    public static void CzySsak(List<Animal> zwierzaki)
    {
      Console.Clear();
      if (zwierzaki.Count == 0)
      {
        Console.WriteLine("Pusta Lista. Wciśnij cokolwiek, aby kontynuować.");
        Console.ReadKey();
        Menu(zwierzaki);
      }
      else
      {
        foreach (var element in zwierzaki)
        {
          Console.WriteLine(
            $"ID: {element.ID}, Imię: {element.Imie}, Wiek: {element.Wiek}, Data Urodzenia: {element.DataUrodzenia}");
        }
        Console.WriteLine("Podaj ID zwierzaka : ");
        int ID = int.Parse(Console.ReadLine());
        if (zwierzaki[ID - 1].RodzajZwierzecia == Animal.Rodzaj.Ssak)
        {
          Console.WriteLine("Ssak");
          Console.WriteLine("Wscisnij cokolwiek");
          Console.ReadKey();
          Menu(zwierzaki);
        }
        else
        {
          Console.WriteLine("Zwierzę nie jest ssakiem!");
          Console.WriteLine("Wcisnij cokolwiek");
          Console.ReadKey();
          Menu(zwierzaki);
        }
      }
    }

  }
}