using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IPhonable
    {
        public string Calling(string number)
        {
            foreach (var digit in number)
            {
                if (char.IsLetter(digit))
                {
                    return "Invalid number!";
                }
            }
            return $"Dialing... {number}";
        }
    }
}
