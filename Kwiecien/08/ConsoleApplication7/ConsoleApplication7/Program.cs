using System.Collections.Generic;

namespace ConsoleApplication7
{
    interface Employee
    {
        string Name { get; set; }
    }

    class Junior : Employee
    {
        public string Name { get; set; }
    }
    class Manager : Employee
    {
        public string Name { get; set; }
        private List<Junior> List = new List<Junior>();

        public void AddJunior(Junior junior)
        {
            List.Add(junior);
        }

        public void RemoveJunior(Junior junior)
        {
            List.Remove(junior);
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}