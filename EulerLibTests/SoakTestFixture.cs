using System.Reflection;
using EulerLib;
using EulerLib.Extensions;

namespace EulerLibTests;

[TestFixture]
public class SoakTestFixture
{
    [Test]
    public void RunAllSolvedProblems()
    {
        // Get All Problems
        var problems = Assembly
            .GetAssembly(typeof(IProblem))!
            .GetTypes()
            .Where(typeof(IProblem).IsAssignableFrom)
            .Where(t => t.IsClass)
            .OrderBy(t => t.Name)
            .Select(t => (IProblem)Activator.CreateInstance(t)!);

        var failures = new List<string>();

        foreach (var problem in problems)
        {
            var solution = problem.Solve();

            var md5OfSolution = solution.ToMd5Hash();
            if (!md5OfSolution.Equals(problem.Md5OfSolution))
            {
                failures.Add(
                    $"Problem {problem.Id} is not returning the expected solution (expected {problem.Md5OfSolution} found {md5OfSolution})");
            }
        }

        if (failures.Count != 0)
        {
            Assert.Fail(string.Join(Environment.NewLine, failures));
        }
    }
}