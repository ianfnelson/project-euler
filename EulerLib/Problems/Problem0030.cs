namespace EulerLib.Problems
{
    public class Problem0030 : IProblem
    {
        public int Id
        {
            get { return 30; }
        }

        public string Title
        {
            get { return "Digit Fifth Powers"; }
        }

        public string Solve()
        {
            return new EulerLibFSharp.Problem0030().sumOfNumbersThatCanBeBeWrittenAsSumOfNthPower(5).ToString();
        }

        public string Md5OfSolution
        {
            get { return "27a1779a8a8c323a307ac8a70bc4489d"; }
        }
    }
}