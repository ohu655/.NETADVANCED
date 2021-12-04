using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public interface IAddable
    {
        public List<string> List { get; set; }

        public int AddToCollection(string element);
    }
}
