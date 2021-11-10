using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;

        private int currentPosition;

        public ListyIterator(params T[] data)
        {
            collection = new List<T>(data);
        }

        public bool Move()
        {
            bool result = HasNext();

            if (result)
            {
                currentPosition++;
            }

            return result;
        }

        public bool HasNext()
        {
            if (currentPosition < collection.Count - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            if (collection.Count == 0)
            {
                Console.WriteLine("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(collection[currentPosition]);
            }
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", collection));
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < collection.Count; i++)
            {
                yield return collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
