using EulerLib.Sequences;

namespace EulerLibTests.Sequences
{
    [TestFixture]
    public class AbundantNumbersFixture
    {
        [TestCase(0, 12)]
        [TestCase(1, 18)]
        [TestCase(2, 20)]
        [TestCase(3, 24)]
        [TestCase(4, 30)]
        public void AbundantsTestCases(int index, int value)
        {
            var sequence = new AbundantNumbers().GenerateToMaximumSize(index+1).ToList();

            Assert.That(sequence.Count, Is.EqualTo(index+1));
            Assert.That(sequence[index], Is.EqualTo(value));
        }

        [Test]
        public void AbundantsTestCases_UsingGenerateToMaximumValue()
        {
            var sequence = new AbundantNumbers().GenerateToMaximumValue(30);

            sequence.Should().AllBeEquivalentTo(new []{12,18,20,24,30});
        }
    }
}