using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        
        private List<Book> books;
        private int currentIndex;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.Reset();
            this.books = new List<Book>(books);
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public bool MoveNext()
        {
            currentIndex++;

            return currentIndex < books.Count;
        }

        public void Dispose()
        {
          
        }

        public Book Current => books[currentIndex];

        object IEnumerator.Current => Current;

    }
}
