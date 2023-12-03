namespace EulerLib.Sets;

public static class Permutator
{
    public static IEnumerable<string> Permute(string[] array, int left, int right)
    {
        if (left == right)
        {
            yield return string.Concat(array);
        }

        for (var i = left; i <= right; i++)
        {
            Swap(array, left, i);

            foreach (var permutation in Permute(array, left + 1, right))
            {
                yield return permutation;
            }
                
            Swap(array, left, i);
        }
    }
    
    private static void Swap(IList<string> array, int i, int j)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}