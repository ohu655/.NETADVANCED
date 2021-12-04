using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : Iidentifiable
    {
        public Pet(string birthDate)
        {
            BirthDate = birthDate;
        }

        public string BirthDate { get; set; }

        public void GetBirthyear(string year)
        {
            string result = BirthDate.Substring(BirthDate.Length - year.Length);

            if (result == year)
            {
                Console.WriteLine(BirthDate);
            }
        }
    }
}
