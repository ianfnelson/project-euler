using EulerLib.Problems;

namespace EulerLibTests.Problems;

[TestFixture]
public class Problem0037Fixture
{
    [Test]
    public void GetTruncatedValuesTest()
    {
        var list = Problem0037.GetTruncatedValues(3797).ToList();

        Assert.That(list.Count, Is.EqualTo(6));
        Assert.That(list.Sum(), Is.EqualTo(1320));
    }
}