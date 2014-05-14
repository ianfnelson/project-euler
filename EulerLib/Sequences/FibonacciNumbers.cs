using System.Collections.Generic;

namespace EulerLib.Sequences
{
    public class FibonacciNumbers : SequenceGeneratorBase
    {
        public override IEnumerable<long> Generate()
        {
            var a = 0;
            var b = 1;

            do
            {
                var result = a + b;
                a = b;
                b = result;

                yield return result;

            } while (true);
        }
    }
}