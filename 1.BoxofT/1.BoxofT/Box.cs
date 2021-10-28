using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BoxOfT
{
    public class Box<T>
    {
        public Box()
        {

        }

        public List<T> List { get; set; } = new List<T>();

        public int Count { get; private set; }

        public void Add(T element)
        {

            List.Add(element);
            Count++;

        }

        public T Remove()
        {
            T value = List[Count - 1];
            List.RemoveAt(Count - 1);
            Count--;
            return value;
        }
    }
}
