using System;
using System.Globalization;

namespace Katas.CodeWars
{
    public static class FormatCurrency
    {
        public static string ToCurrency(this decimal value, string currencySymbol)
        {
            decimal number = Math.Round(value, 2);
            string s = number.ToString("0.00", CultureInfo.InvariantCulture);
            if (s.StartsWith("-"))
            {
                s = s.Insert(1, currencySymbol);
            }
            else
            {
                s = currencySymbol + s;
            }
            return s;
        }
    }
}