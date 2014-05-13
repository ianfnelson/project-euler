namespace EulerLib
{
    public interface IProblem
    {
        int Id { get; }
        string Title { get; }
        string Solve();
    }
}