using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public interface IPerson
    {
        public string Model { get; set; }

        public string Id { get; set; }

        public void IsFake(string digits);
    }
}
