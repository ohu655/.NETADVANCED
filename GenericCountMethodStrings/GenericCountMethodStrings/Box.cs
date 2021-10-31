using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodStrings
{
    public class Box<T>
        where T : IComparable
    {
        private List<T> items;

        public Box()
        {
            items = new List<T>();
        }

        public void Add(T value)
        {
            items.Add(value);
        }

        public int Compare(T item)
        {
            int count = 0;

            foreach (var element in items)
            {
                if (element.CompareTo(item) > 0)
                {
                    count++;
                }             
            }

            return count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in items)
            {
                sb.AppendLine($"System.Int32: {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
