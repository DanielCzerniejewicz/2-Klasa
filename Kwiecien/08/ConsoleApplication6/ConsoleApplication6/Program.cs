using System.Collections.Generic;

namespace ConsoleApplication6
{
    interface Graphic
    {
        void Draw();
    }

    class Line : Graphic
    {
        public void Draw()
        {
            
        }
    }
    class Rectangle : Graphic
    {
        public void Draw()
        {
            
        }
    }
    class Text : Graphic
    {
        public void Draw()
        {
            
        }
    }

    class Picture : Graphic
    {
        private List<Graphic> list = new List<Graphic>();
        public void Draw()
        {
            
        }

        public void Add(Graphic g)
        {
            list.Add(g);
        }

        public void Remove(Graphic graphic)
        {
            list.Remove(graphic);
        }

        public void GetChild(int n)
        {
            
        }
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}