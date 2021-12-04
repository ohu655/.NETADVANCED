using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddRemoveCollection : IAddable, IAddRemoveCollection
    {
        public AddRemoveCollection()
        {
            List = new List<string>();
        }

        public List<string> List { get; set; }

        public int AddToCollection(string element)
        {
            List.Insert(0, element);

            return 0;
        }

        public string RemoveFromCollection()
        {
            string element = List[List.Count - 1];
            List.RemoveAt(List.Count - 1);
            return element;
        }
    }
}
