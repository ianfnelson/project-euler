﻿namespace EulerLib.Extensions;

public static class StringExtensions
{
    public static string ReverseString(this string value)
    {
        var charArray = value.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static bool IsPalindromic(this string value)
    {
        return value.Equals(value.ReverseString());
    }
}