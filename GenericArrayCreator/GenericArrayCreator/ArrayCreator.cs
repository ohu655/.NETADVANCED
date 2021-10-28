using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var Array = new T[length];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = item;
            }
            return Array;
        }
    }
}
