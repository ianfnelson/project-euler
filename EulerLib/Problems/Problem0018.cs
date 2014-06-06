using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EulerLib.Problems
{
    public class Problem0018 : IProblem
    {
        public int Id
        {
            get { return 18; }
        }

        public string Title
        {
            get { return "Maximum Path Sum I"; }
        }

        public string Solve()
        {
            var executingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(executingDirectory, "ContentFiles\\problem0018.txt");
            return MaximumPathThroughTriangle(filePath).ToString();
        }

        public long MaximumPathThroughTriangle(string filePath)
        {
            var triangle = ParseFile(filePath);

            for (var row = triangle.Count-2; row >= 0; row--)
            {
                for (var cell = 0; cell < triangle[row].Length; cell++)
                {
                    triangle[row][cell] += Math.Max(triangle[row + 1][cell], triangle[row + 1][cell + 1]);
                }
            }

            return triangle[0][0];
        }

        private List<int[]> ParseFile(string filePath)
        {
            return File.ReadLines(filePath)
                       .Where(x => !string.IsNullOrWhiteSpace(x))
                       .Select(ParseLine)
                       .ToList();
        }

        private int[] ParseLine(string line)
        {
            return line.Split(' ').Select(int.Parse).ToArray();
        }

        public string Md5OfSolution
        {
            get { return "708f3cf8100d5e71834b1db77dfa15d6"; }
        }
    }
}