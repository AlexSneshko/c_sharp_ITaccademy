using System;
using Lib;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();

            var book1 = new Book("book1", "library", 10);
            var book2 = new Book("book2", "library", 150);
            var book3 = new Book("book3", "library", 180);
            var book4 = new Book("book4", "library", 40);
            var book5 = new Book("book5", "library", 1060);
            var book6 = new Book("book6", "library", 500);
            library.PutBooks(book1, book2, book3, book4, book5, book6);
            Console.WriteLine(library.ToString());

            //Task 1
            Console.WriteLine(library[2].ToString());

            //Task 2
            Console.WriteLine(library.GetByTitle("book3").ToString());
            Console.WriteLine(library.GetByTitle("book")?.ToString());

            //Task 3
            Console.WriteLine(library.GetBiggestBook().ToString());

            //Extra Task
            Console.WriteLine("\n\n\n");
            var array = new int[] { 4, 1, 5, 7, 3, 9, 2, 0 };
            array.SortByIncreasing();
            Console.WriteLine(array.ToString(2)); 
        }
    }
}
