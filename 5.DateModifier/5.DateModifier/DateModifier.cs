using System;
using System.Collections.Generic;
using System.Text;

namespace _5.DateModifier
{
    public static class DateModifier
    {
        public static int CalculateDate(string firstDate, string secondDate)
        {
            DateTime dateOne = DateTime.Parse(firstDate);
            DateTime dateTwo = DateTime.Parse(secondDate);

            int result = Math.Abs((dateOne - dateTwo).Days);

            return result;
        }
    }
}
