using System.IO;
using System.Reflection;

namespace EulerLib.Problems
{
    public class Problem0067 : IProblem
    {
        public int Id
        {
            get { return 67; }
        }

        public string Title
        {
            get { return "Maximum path sum II"; }
        }

        public string Solve()
        {
            var executingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(executingDirectory, "ContentFiles\\triangle.txt");

            var problem18 = new Problem0018();
            return problem18.MaximumPathThroughTriangle(filePath).ToString();
        }

        public string Md5OfSolution
        {
            get { return "9d702ffd99ad9c70ac37e506facc8c38"; }
        }
    }
}