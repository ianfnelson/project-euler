namespace EulerLib.Problems;

public class Problem0092 : IProblem
{
    public int Id => 92;
    public string Title => "Square Digit Chains";

    private const int MaxSumOfSquares = 7 * 9 * 9;
    private readonly int[] _memos = new int[MaxSumOfSquares + 1];
    
    public string Solve()
    {
        var eightyNiners = 0;
        
        for (var a = 1; a <= MaxSumOfSquares; a++)
        {
            var endValue = EndValue(a);
            _memos[a] = endValue;

            if (endValue == 89)
            {
                eightyNiners++;
            }
        }
        
        for (var i = MaxSumOfSquares + 1; i < 10000000; i++)
        {
            var nextValue = SumOfSquareOfDigits(i);
            if (_memos[nextValue] == 89)
            {
                eightyNiners++;
            }
        }
        
        return eightyNiners.ToString();
    }

    public static int EndValue(int number)
    {
        do
        {
            number = SumOfSquareOfDigits(number);
        } while (number != 1 && number != 89);

        return number;
    }

    public string Md5OfSolution => "6cee918c0612bccc2dac03d05e07035f";

    public static int SumOfSquareOfDigits(int number)
    {
        return number
            .ToString()
            .Select(c => c - '0')
            .Select(c => c * c)
            .Sum();
    }
}