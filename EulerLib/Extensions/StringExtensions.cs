using System;

namespace EulerLib.Extensions
{
    public static class StringExtensions
    {
        public static string ReverseString(this string value)
        {
            if (value == null) return null;

            var charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}