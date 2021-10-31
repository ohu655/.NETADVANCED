using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    class Box
    {
        public void Swap<T>(List<T> list, int index1, int index2)
        {
            T currentElement = list[index1];

            list[index1] = list[index2];
            list[index2] = currentElement;

        }
    }
}
