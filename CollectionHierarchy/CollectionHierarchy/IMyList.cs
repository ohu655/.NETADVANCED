using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface IMyList : IAddable, IAddRemoveCollection
    {
        public int Used => List.Count;
    }
}
