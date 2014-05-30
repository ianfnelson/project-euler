namespace EulerLib.Problems
{
    public class Problem0029 : IProblem
    {
        public int Id
        {
            get { return 29; }
        }

        public string Title
        {
            get { return "Distinct Powers"; }
        }

        public string Solve()
        {
            return CountDistinctPowersThrough(100).ToString();
        }

        public int CountDistinctPowersThrough(int n)
        {
            return new EulerLibFSharp.Problem0029().distinctPowers(n);
        }

        public string Md5OfSolution
        {
            get { return "6f0ca67289d79eb35d19decbc0a08453"; }
        }
    }
}