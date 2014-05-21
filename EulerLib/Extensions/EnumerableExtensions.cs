using System.Collections.Generic;

namespace EulerLib.Extensions
{
    public static class EnumerableExtensions
    {
        public static HashSet<T> ToHashSet<T>(this IEnumerable<T> value)
        {
            return new HashSet<T>(value);
        }
    }
}