namespace ConsoleApplication2
{
    class Client{}

    class WashingMashine
    {
        Washing washing;
        Rinsing rinsing;
        Spinning spinning;

        public void WezToWypierz()
        {
            washing = new Washing();
            rinsing = new Rinsing();
            spinning = new Spinning();
        }
    }

    class Washing
    {
        public void wash()
        {
            
        }
    }

    class Rinsing
    {
        public void rinse()
        {
            
        }
    }

    class Spinning
    {
        public void spin()
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