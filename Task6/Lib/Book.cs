using System;

namespace Lib
{
    public class Book
    {
        private string title;
        private string library;
        private int pages;

        public Book(string title, string library, int pages)
        {
            this.title = title;
            this.library = library;
            this.pages = pages;
        }

        public bool CompareTitle(string otherTitle)
        {
            if (title == otherTitle) return true;
            return false;
        }

        public bool ComparePages(Book otherBook)
        {
            if (pages < otherBook.pages) return true;
            return false;
        }

        public override string ToString()
        {
            return String.Format("Book: {0} \nIn library: {1} \nPages: {2}\n\n", title, library, pages);
        }
    }
}
