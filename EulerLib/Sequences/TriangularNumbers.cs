namespace EulerLib.Sequences
{
    public class TriangularNumbers : SequenceGeneratorBase
    {
        public override IEnumerable<long> Generate()
        {
            var a = 1;
            var tot = 0;

            do
            {
                tot += a;
                a++;
                yield return tot;
            } while (true);
        }
    }
}