using System;

namespace ConsoleApplication1.Classes
{
    public class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public void GetAdress()
        {
            Console.WriteLine($"Miasto : " +City + "Ulica : " +Street + "Numer Domu : " +HouseNumber + "Kod pocztowy : " +PostalCode);
        }
    }
}