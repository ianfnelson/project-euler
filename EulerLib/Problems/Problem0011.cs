using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EulerLib.Problems
{
    public class Problem0011 : IProblem
    {
        public int Id
        {
            get { return 11; }
        }

        public string Title
        {
            get { return "Largest product in a grid"; }
        }

        public string Solve()
        {
            var executingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(executingDirectory, "ContentFiles\\problem0011.txt");
            return MaximumProductInAGrid(filePath, 4).ToString();
        }

        public int MaximumProductInAGrid(string filePath, int adjacentNumbers)
        {
            var grid = ParseFile(filePath);

            var maxHorizontal = MaximumHorizontalProduct(grid, adjacentNumbers);
            var maxVertical = MaximumVerticalProduct(grid, adjacentNumbers);
            var maxDownhill = MaximumDownhillProduct(grid, adjacentNumbers);
            var maxUphill = MaximumUphillProduct(grid, adjacentNumbers);

            return new [] { maxHorizontal, maxVertical, maxDownhill, maxUphill }.Max();
        }

        private int MaximumUphillProduct(List<int[]> grid, int adjacentNumbers)
        {
            var maximumProduct = int.MinValue;

            for (int row = 0; row <= grid.Count() - adjacentNumbers; row++)
            {
                for (int column = 0; column <= grid[row].Count() - adjacentNumbers; column++)
                {
                    int product = 1;
                    for (int looper = 0; looper < adjacentNumbers; looper++)
                    {
                        product *= grid[row + looper][column + adjacentNumbers - looper -1];
                    }

                    if (product > maximumProduct) maximumProduct = product;
                }
            }

            return maximumProduct;
        }

        private int MaximumDownhillProduct(List<int[]> grid, int adjacentNumbers)
        {
            var maximumProduct = int.MinValue;

            for (int row = 0; row <= grid.Count() - adjacentNumbers; row++)
            {
                for (int column = 0; column <= grid[row].Count()-adjacentNumbers; column++)
                {
                    int product = 1;
                    for (int looper = 0; looper < adjacentNumbers; looper++)
                    {
                        product *= grid[row+looper][column+looper];
                    }

                    if (product > maximumProduct) maximumProduct = product;
                }
            }

            return maximumProduct;
        }

        private int MaximumVerticalProduct(List<int[]> grid, int adjacentNumbers)
        {
            var maximumProduct = int.MinValue;

            for (int row = 0; row <= grid.Count() - adjacentNumbers; row++)
            {
                for (int startColumn = 0; startColumn < grid[row].Count();startColumn++)
                {
                    int product = 1;
                    for (int rowIndex = row; rowIndex < row + adjacentNumbers; rowIndex++)
                    {
                        product *= grid[rowIndex][startColumn];
                    }

                    if (product > maximumProduct) maximumProduct = product;
                }
            }

            return maximumProduct;
        }

        private int MaximumHorizontalProduct(IEnumerable<int[]> grid, int adjacentNumbers)
        {
            var maximumProduct = int.MinValue;

            foreach (var row in grid)
            {
                for (int startColumn = 0; startColumn <= row.Length-adjacentNumbers; startColumn++)
                {
                    int product = 1;
                    for (int columnIndex = startColumn; columnIndex < startColumn+adjacentNumbers; columnIndex++)
                    {
                        product = product*row[columnIndex];
                    }

                    if (product > maximumProduct) maximumProduct = product;
                }
            }

            return maximumProduct;
        }


        private List<int[]> ParseFile(string filePath)
        {
            return File.ReadAllLines(filePath)
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
            get { return "678f5d2e1eaa42f04fa53411b4f441ac"; }
        }
    }
}