namespace EulerLib
{
    public interface IProblem
    {
        int Id { get; }
        string Solve();
    }
}