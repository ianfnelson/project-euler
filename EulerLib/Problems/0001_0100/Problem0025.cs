using System.Numerics;
using EulerLib.Extensions;

namespace EulerLib.Problems;

public class Problem0025 : IProblem
{
    public int Id => 25;
    public string Title => "1000-digit Fibonacci Number";
    public string Solve()
    {
        return IndexOfFirstFibonacciNumberToContainNDigits(1000).ToString();
    }

    public static int IndexOfFirstFibonacciNumberToContainNDigits(int n)
    {
        BigInteger a = 1;
        BigInteger b = 1;
        var index = 2;

        BigInteger next;
        do
        {
            next = a + b;
            a = b;
            b = next;
            index++;

        } while (next.Digits()<n);

        return index;
    }

    public string Md5OfSolution => "a376802c0811f1b9088828288eb0d3f0";
}