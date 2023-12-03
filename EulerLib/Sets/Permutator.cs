namespace EulerLib.Sets;

public static class Permutator
{
    public static IEnumerable<string> Permute(string[] array)
    {
        int n = array.Length;
        int[] indexes = Enumerable.Range(0, n).ToArray();

        yield return string.Concat(array);

        while (true)
        {
            var i = n - 1;
            while (i > 0 && indexes[i - 1] >= indexes[i])
                i--;

            if (i == 0)
                yield break; 

            var j = n - 1;
            while (indexes[j] <= indexes[i - 1])
                j--;

            Swap(ref indexes[i - 1], ref indexes[j]);

            Array.Reverse(indexes, i, n - i);

            yield return string.Concat(indexes.Select(index => array[index]));
        }
    }

    private static void Swap<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }
}