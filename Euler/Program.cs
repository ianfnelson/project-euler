// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Reflection;
using EulerLib;
using EulerLib.Extensions;

var problems = GetProblems(args);

foreach (var problem in problems)
{
    Solve(problem);
}

return;

void Solve(IProblem problem)
{
    Console.WriteLine("Problem ID:      {0}", problem.Id);
    Console.WriteLine("Title:           {0}", problem.Title);

    var sw = new Stopwatch();
    sw.Start();

    var solution = problem.Solve();

    sw.Stop();

    Console.WriteLine("Solution:        {0}", solution);
    Console.WriteLine("MD5 of solution: {0}", solution.ToMd5Hash());
    Console.WriteLine("Execution Time:  {0:n0} milliseconds", sw.ElapsedMilliseconds);
    Console.WriteLine("");
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

    int problemId;
    if (!int.TryParse(args[0], out problemId))
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
    var typeName = string.Format("Problem{0:0000}", problemId);

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
