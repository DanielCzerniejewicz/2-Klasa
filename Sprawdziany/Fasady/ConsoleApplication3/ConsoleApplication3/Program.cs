using System.Collections.Generic;

namespace ConsoleApplication3
{
  internal class Program
  {
    abstract class Composite
    {
      public abstract void operation();
      public void add(){}
      public void remove(){}
      public  void getChild(){}
    }

    abstract class Component : Composite
    {
      public override void operation(){}
    }

    class Leaf : Component
    {
      public override void operation(){}
    }
    public static void Main(string[] args)
    {
    }
  }
}

namespace Composite2
{
  class Graphic
  {
    public void Draw(){}
    public List<Graphic> grafiki = new List<Graphic>();
  }

  class Text : Graphic
  {
    public void Draw(){}
  }
  class Line : Graphic
  {
    public void Draw(){}
  }
  class Rectangle : Graphic
  {
    public void Draw(){}
  }
  class Picture : Graphic
  {
    public void Draw(){}

    public void Add(Graphic g)
    {
      grafiki.Add(g);
    }

    public void Remove(Graphic g)
    {
      grafiki.Remove(g);
    }

    public void GetChild(int i)
    {
      
    }
  }
  
}

namespace Composite3
{
  interface Employee
  {
    string Name { get; set; }
    void GetName();
    void SetName();
  }

  class Junior : Employee
  {
    public string Name { get; set; }
    public void GetName(){}
    public void SetName(){}
  }
  class Manager : Employee
  {
    public List<Employee> Employees = new List<Employee>();
    public string Name { get; set; }
    public void GetName(){}
    public void SetName(){}

    public void AddJunior()
    {
      Junior j = new Junior();
      Employees.Add(j);
    }

    public void RemoveJunior()
    {
      Junior junior = new Junior();
      Employees.Remove(junior);
    }
  }
}

namespace SprGR2
{
  interface Robotny
  {
    string Robota { get; set; }
    void Planuj();
    void dzialaj(Zadanie z);
  }

  class Gracz : 
  {
    private string
  }
  class Zadanie
  {
    private string TrescZadania;
  }
}