namespace EulerLib.Sequences;

public class SquareNumbers : SequenceGeneratorBase
{
    public override IEnumerable<long> Generate()
    {
        var a = 0;

        do
        {
            a++;
            yield return a * a;
        } while (true);
    }
}