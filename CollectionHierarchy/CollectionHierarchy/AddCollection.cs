using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionHierarchy
{
    public class AddCollection : IAddable
    {

        public AddCollection()
        {
            List = new List<string>();
        }

        public List<string> List { get; set; }

        public int AddToCollection(string element)
        {
            List.Add(element);

            return List.Count - 1;
        }
    }
}
