using System;
using System.Collections.Generic;
using System.Text;

namespace Lib
{
    public static class LibraryExtension
    {
        public static Book GetBiggestBook(this Library library)
        {
            var biggestBook = library[0];

            for (int i = 1; i < library.GetSize(); i++)
                if (biggestBook.ComparePages(library[i]))
                    biggestBook = library[i];

            return biggestBook;
        }
    }
}
