using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class MyList : IAddable, IAddRemoveCollection, IMyList
    {
        public MyList()
        {
            List = new List<string>();
        }

        public List<string> List { get; set; }

        public int Used => List.Count;

        public int AddToCollection(string element)
        {
            List.Insert(0, element);

            return 0;
        }

        public string RemoveFromCollection()
        {
            string element = List[0];
            List.RemoveAt(0);
            return element;
        }
    }
}
