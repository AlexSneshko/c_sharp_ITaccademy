using System;
using System.Collections.Generic;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            var alex = new Human("Alex", "Pulon", 1220);
            var danik = new Human("Danik", "Nol", 23);
            var vasya = new Human("Vasya1", "Joker", 23);
            var petya = new Human("Petya", "Bu2ler", 23);

            var people = new List<Human>() { alex, danik, vasya, petya };

            foreach(var person in people)
            {
                Console.WriteLine(person);
                person.CheckProperties();
                Console.WriteLine();
            }
        }
    }
}
