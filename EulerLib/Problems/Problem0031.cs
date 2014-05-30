namespace EulerLib.Problems
{
    public class Problem0031 : IProblem
    {
        public int Id
        {
            get { return 31; }
        }

        public string Title
        {
            get { return "Coin sums"; }
        }

        private static readonly int[] CoinSizes = { 1, 2, 5, 10, 20, 50, 100, 200 };

        public string Solve()
        {
            return WaysOfMaking(200).ToString();
        }

        public int WaysOfMaking(int target)
        {
            var ways = new int[target + 1];
            ways[0] = 1;

            for (int i = 0; i < CoinSizes.Length; i++)
            {
                for (int j = CoinSizes[i]; j <= target; j++)
                {
                    ways[j] += ways[j - CoinSizes[i]];
                }
            }

            return ways[ways.Length - 1];
        }

        public string Md5OfSolution
        {
            get { return "142dfe4a33d624d2b830a9257e96726d"; }
        }
    }
}