using System;

namespace ConsoleApplication1.Classes
{
    public class Adress
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }

        public string GetAdress()
        {
            return $"Adres: {City} {Street} {HouseNumber} {PostalCode}";
        }
    }
}