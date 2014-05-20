using System;
using System.IO;
using System.Linq;
using EulerLib.Poker;

namespace EulerLib.Problems
{
    public class Problem0054 : IProblem
    {
        public int Id
        {
            get { return 54; }
        }

        public string Title
        {
            get { return "Poker hands"; }
        }

        public string Solve()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ContentFiles\\poker.txt");
            return CountPlayer1WinsInFile(filePath).ToString();
        }

        public int CountPlayer1WinsInFile(string filePath)
        {
            return File.ReadLines(filePath)
                       .Where(x => !string.IsNullOrWhiteSpace(x))
                       .Select(ParseHands)
                       .Count(hands => hands.Item1.CompareTo(hands.Item2) == 1);
        }

        public Tuple<Hand, Hand> ParseHands(string line)
        {
            var hand1Input = line.Substring(0, 14);
            var hand2Input = line.Substring(15, 14);

            var hand1 = Hand.Parse(hand1Input);
            var hand2 = Hand.Parse(hand2Input);

            return new Tuple<Hand, Hand>(hand1, hand2);
        }
    }
}