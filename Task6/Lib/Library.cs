using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public class Library
    {
        private Book[] books;

        public Library()
        {
            books = new Book[0];
        }
        

        public void PutBooks(params Book[] newBooks)
        {
            Array.Resize<Book>(ref books, books.Length + newBooks.Length);
            Array.Copy(newBooks, 0, books, books.Length - newBooks.Length, newBooks.Length);
        }

        public Book GetByTitle(string title)
        {
            foreach (var book in books)
                if (book.CompareTitle(title))
                    return book;
            Console.WriteLine("No such book");
            return null;
        }

        public int GetSize()
        {
            return books.Length;
        }

        public Book this[int index]
        {
            get
            {
                return books[index];
            }
        }

        public override string ToString()
        {
            StringBuilder liba = new StringBuilder();

            foreach (var book in books)
                liba.Append(book.ToString());
            liba.Append("----------------------------------------\n");

            return liba.ToString();
        }
    }
}
