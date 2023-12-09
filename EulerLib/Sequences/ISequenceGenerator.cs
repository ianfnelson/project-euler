namespace EulerLib.Sequences
{
    public interface ISequenceGenerator<T>
    {
        IEnumerable<T> Generate();

        IEnumerable<T> GenerateToMaximumValue(long maximumValue);
        IEnumerable<T> GenerateToMaximumValue(int maximumValue);
        IEnumerable<T> GenerateToMaximumSize(long maximumSize);
        IEnumerable<T> GenerateToMaximumSize(int maximumSize);
    }
}