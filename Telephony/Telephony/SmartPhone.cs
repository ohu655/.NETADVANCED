using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class SmartPhone : ISmartPhonable
    {
        public string Browsing(string URL)
        {
            foreach (var symbol in URL)
            {
                if (char.IsDigit(symbol))
                {
                    return "Invalid URL!";
                }
            }

            return $"Browsing: {URL}!";
        }

        public string Calling(string number)
        {
            foreach (var digit in number)
            {
                if (char.IsLetter(digit))
                {
                    return "Invalid number!";
                }
            }

            return $"Calling... {number}";
        }
    }
}
