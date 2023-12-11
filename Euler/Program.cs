// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Reflection;
using EulerLib;
using EulerLib.Extensions;

var problems = GetProblems(args);
var solutions = problems.Select(problem => new Tuple<IProblem, long>(problem, Solve(problem))).ToList();

Console.WriteLine("Slowest solutions:");
foreach (var slowSolution in solutions.OrderByDescending(x => x.Item2).Take(5))
{
    Console.WriteLine("Problem ID {0} - {1:n0} ms", slowSolution.Item1.Id, slowSolution.Item2);
}
Console.WriteLine("");
Console.WriteLine("Mean solution time: {0:n0} ms", solutions.Average(x => x.Item2));

return;

long Solve(IProblem problem)
{
    Console.WriteLine("Problem ID:      {0}", problem.Id);
    Console.WriteLine("Title:           {0}", problem.Title);

    var sw = new Stopwatch();
    sw.Start();

    var solution = problem.Solve();

    sw.Stop();

    Console.WriteLine("Solution:        {0}", solution);
    Console.WriteLine("MD5 of solution: {0}", solution.ToMd5Hash());
    Console.WriteLine("Execution Time:  {0:n0} ms", sw.ElapsedMilliseconds);
    Console.WriteLine("");

    return sw.ElapsedMilliseconds;
}

static IEnumerable<IProblem> GetProblems(string[] args)
{
    var problemType = typeof (IProblem);

    if (args.Length == 0)
    {
        return Assembly.GetAssembly(problemType)
            .GetTypes()
            .Where(problemType.IsAssignableFrom)
            .Where(t => t.IsClass)
            .OrderBy(x => x.Name)
            .Select(x => (IProblem) Activator.CreateInstance(x));
    }

    if (!int.TryParse(args[0], out var problemId))
    {
        Console.WriteLine(
            "'{0}' is not a valid integer. Please pass the integer ID of the problem to be solved", args[0]);
        return null;
    }
    
    if (problemId < 1 || problemId > 9999)
    {
        Console.WriteLine("'{0}' is out of range. Please pass the integer ID of the problem to be solved",
            args[0]);
        return null;
    }
    
    IProblem problem;
    var typeName = $"Problem{problemId:0000}";

    try
    {
        var type = Assembly.GetAssembly(problemType)
            .GetTypes()
            .Single(x => x.Name.Equals(typeName));

        problem = (IProblem) Activator.CreateInstance(type);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Unable to instantiate type with name '{0}' - {1}", typeName, ex.Message);
        return null;
    }

    return new []{problem};
}
