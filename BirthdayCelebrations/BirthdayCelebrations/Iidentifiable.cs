using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public interface Iidentifiable
    {
        public string BirthDate { get; set; }

        public void GetBirthyear(string year);

    }
}
