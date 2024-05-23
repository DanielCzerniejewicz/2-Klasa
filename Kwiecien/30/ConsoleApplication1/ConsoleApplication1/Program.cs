using System;
namespace _12_1_dziedziczenie
{
  //typ wyliczeniowy dla rodzajów paliwa
  public enum FuelType
  {
    Petrol, //Benzyna
    Diesel, //Olej napędowy
    Electric //Elektryczny
  }
  //klasa bazowa
  public class ElectricCar : Car
  {
    public double BatteryCapacity { get; set; }

    public override void StartEngine()
    {
      base.StartEngine();
    }
  }
  public class Vehicle
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Fuel { get; protected set; } //poziom paliwa
    public FuelType FuelType { get; set; } //typ paliwa
    public ushort Speed { get; set; } //aktualna prędkość pojazdu

    public virtual void StartEngine()
    {
      Console.WriteLine("\nSilnik uruchomiony\n");
    }
    public virtual void StopEngine()
    {
      Console.WriteLine("\nSilnik zatrzymany\n");
    }
    public void Refuel(double amount)
    {
      Fuel += amount;
      Console.WriteLine($"\nZatankowano {amount} litrów paliwa w pojeździe\n");
    }
    public void UpdateSpeed(ushort newSpeed)
    {
      Speed = newSpeed;
    }
  }

  public class Car : Vehicle
  {
    public byte NumberOfDoors { get; set; } //liczba drzwi
    public int CurrentGear { get; private set; } //aktualny bieg
    public int MaxGear { get; set; } //maksymalny bieg
    public bool IsAutomatic { get; set; } //czy skrzynia jest automatyczna
    public override void StartEngine()
    {
      //base.StartEngine();
      Console.WriteLine("\nSilnik samochodu uruchomiony\n"); //przesłanianie metody bazowej
    }

    public override void StopEngine()
    {
      Console.WriteLine("\nSilnik samochodu zatrzymany\n");
    }

    //metoda do zmiany biegów
    public void ChangeGear(byte gear)
    {
      if (IsAutomatic)
      {
        Console.WriteLine("\nTen samochód ma automatyczną skrzynię biegów");
      }
      else
      {
        if (gear < 0 || gear > MaxGear)
        {
          Console.WriteLine("\nNieprawidłowy bieg");
        }
        else
        {
          CurrentGear = gear;
          Console.WriteLine($"\nZmiana biegu na {gear}");
        }
      }
    }

    private void AutomaticGearChange(int speed)
    {
      if (IsAutomatic)
      {
        if (speed < 20)
        {
          CurrentGear = 1;
        }
        else if (speed >= 20 && speed < 40)
        {
          CurrentGear = 2;
        }
        else
        {
          CurrentGear = 3;
        }
        Console.WriteLine($"\nAutomatyczna zmiana biegu na {CurrentGear} dla prędkości {speed} km/h");
      }
      else
      {
        Console.WriteLine("\nManualna skrzynia biegów");
      }
    }
  }
  internal class Program
  {
    static void Main(string[] args)
    {
      ElectricCar electricCar = new ElectricCar
      {
        Brand = "Tesla",
        Model = "S",
        NumberOfDoors = 4,
        FuelType = FuelType.Electric,
        
      };
    }
  }
}