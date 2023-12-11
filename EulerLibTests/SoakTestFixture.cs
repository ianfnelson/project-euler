using System.Reflection;
using EulerLib;
using EulerLib.Extensions;

namespace EulerLibTests
{
    [TestFixture]
    public class SoakTestFixture
    {
        [Test]
        public void RunAllSolvedProblems()
        {
            // Get All Problems
            var problemType = typeof(IProblem);
            var problems = Assembly
                .GetAssembly(problemType)
                .GetTypes()
                .Where(problemType.IsAssignableFrom)
                .Where(t => t.IsClass)
                .OrderBy(x => x.Name)
                .Select(x => (IProblem)Activator.CreateInstance(x));

            var failures = new List<string>();

            foreach (var problem in problems.Where(x => x.Md5OfSolution != null))
            {
                var solution = problem.Solve();

                var md5OfSolution = solution.ToMd5Hash();
                if (!md5OfSolution.Equals(problem.Md5OfSolution))
                {
                    failures.Add(
                        string.Format("Problem {0} is not returning the expected solution (expected {1} found {2})",
                            problem.Id, problem.Md5OfSolution, md5OfSolution));
                }
            }

            if (failures.Count != 0)
            {
                Assert.Fail(string.Join(Environment.NewLine, failures));
            }
        }
    }
}