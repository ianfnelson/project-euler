namespace EulerLib.Sequences;

public class PentagonalNumbers : SequenceGeneratorBase
{
    public override IEnumerable<long> Generate()
    {
        var a = 1;
        var tot = 0;

        do
        {
            tot += a;
            a+=3;
            yield return tot;
        } while (true);
    }
}