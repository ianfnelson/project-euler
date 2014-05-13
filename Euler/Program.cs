using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using EulerLib;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = InstantiateProblem(args);
            if (problem == null) return;

            Console.WriteLine("Solving problem ID {0} - {1}", problem.Id, problem.Title);

            var sw = new Stopwatch();
            sw.Start();

            var solution = problem.Solve();

            sw.Stop();

            Console.WriteLine("Answer: {0}", solution);
            Console.WriteLine("Execution Time: {0:n0} milliseconds", sw.ElapsedMilliseconds);
        }

        private static IProblem InstantiateProblem(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please pass the integer ID of the problem to be solved");
                return null;
            }

            int problemId;
            if (!int.TryParse(args[0], out problemId))
            {
                Console.WriteLine("'{0}' is not a valid integer. Please pass the integer ID of the problem to be solved", args[0]);
                return null;
            }

            if (problemId < 1 || problemId > 9999)
            {
                Console.WriteLine("'{0}' is out of range. Please pass the integer ID of the problem to be solved", args[0]);
                return null;
            }

            IProblem problem;
            var typeName = string.Format("Problem{0:0000}", problemId);

            try
            {
                var type = Assembly.GetAssembly(typeof(IProblem))
                                   .GetTypes()
                                   .Single(x => x.Name.Equals(typeName));

                problem = (IProblem)Activator.CreateInstance(type);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to instantiate type with name '{0}' - {1}", typeName, ex.Message);
                return null;
            }

            return problem;
        }
    }
}
