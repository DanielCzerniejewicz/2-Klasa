using System;
using System.Collections.Generic;
namespace ConsoleApplication1.Classes

{
    class Teacher
    {
        public List<string>Subjects {private get; set; }

        public void GetList()
        {
            Console.WriteLine(string.Join(", ", Subjects));
        }
    }
}