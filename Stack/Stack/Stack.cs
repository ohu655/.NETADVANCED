using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack(params T[] data)
        {
            stack = new List<T>(data);
        }

        public void Push(params T[] elements)
        {
            foreach (var element in elements)
            {
                stack.Insert(stack.Count, element);
            }         
        }

        public T Pop()
        {

            T element = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);
            return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
