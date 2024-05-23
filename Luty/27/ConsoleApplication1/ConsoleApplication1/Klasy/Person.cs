using System;

namespace ConsoleApplication1.Klasy
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public static int Counter = 0; //Licznik ile powstalo obiektow klasy person
        /*
        Konstruktor Statyczny jest wywolywany automatycznie aby zainicjowac
        klase przed utworzeniem pierwszej instancji (to statyczne cos sie tylko raz wywola)
        Nie moze miec zadnego parametru ani modyfikatorow dostepu
         static Person()
         {
             Console.WriteLine("Statyczny Konstruktor klasy Person");
             Counter++;
         }
         */
        /*
         * konstruktor domyslny jest bezparametrowy. Jesli Klasa nie ma żadnego
         * konstruktora to konstruktor domyslny jest wywolywany przy tworzeniu obiektu
         * inicjuje on wszystkie pola właściwości do ich wartości domyslnych
         * jesli zdefiniujemy jaki kolwiek konstruktor parametryczny to nie otrzymamy automatycznie
         * konstruktora domyslnego musimy wtedy go samodzielnie zadeklarowac
        */
        public Person()
        {
            Console.WriteLine("Konstruktor Domyslny klasy Person");
            Name = "Niepodano";
            Surname = "Niepodano";
        }
        /*
        konstruktor parametryczny - ma conajmniej jeden parametr. Służy do inicjowania obiektu pól 
        obiektu zgodnie z wartosciami podanymi przy tworzeniu obiektu. Możemy mieć wiele konstruktorów parametrycznych
        o ile różnią się liczbą lub typem parametrów
        */
        
        
        //konstruktor parametryczny z jednym parametrem
        public Person(string name)
        {
            Name = name;
        }
        //metoda wyswietlaja dane
        public string GetData()
        {
            return $"Imie : {Name} , Nazwisko : {Surname} , Wiek : {Age}";
        }
        //konstruktor parametryczny z 2 parametrami
        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        //konstruktor parametryczny z 3 parametrami
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}