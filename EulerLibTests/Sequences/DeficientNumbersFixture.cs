using EulerLib.Sequences;

namespace EulerLibTests.Sequences;

[TestFixture]
public class DeficientNumbersFixture
{
    [TestCase(0, 1)]
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 4)]
    [TestCase(4, 5)]
    [TestCase(5, 7)]
    [TestCase(10, 13)]
    [TestCase(15, 19)]
    [TestCase(17, 22)]
    [TestCase(20, 26)]
    public void DeficientsTestCases(int index, int value)
    {
        var sequence = new DeficientNumbers().GenerateToMaximumSize(21);

        Assert.That(sequence.ElementAt(index), Is.EqualTo(value));
    }
}