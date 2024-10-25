namespace EulerLib.Sequences;

public class HexagonalNumbers : SequenceGeneratorBase
{
    public override IEnumerable<long> Generate()
    {
        var a = 1;
        var tot = 0;

        do
        {
            tot += a;
            a+=4;
            yield return tot;
        } while (true);
    }
}