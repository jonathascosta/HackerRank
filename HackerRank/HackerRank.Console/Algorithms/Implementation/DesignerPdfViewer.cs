using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Console.Algorithms.Implementation
{
    public class DesignerPdfViewer : IChallengeSolver
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public void Solve(params string[] args)
        {
            var heightsInput = System.Console.ReadLine();
            var heights = heightsInput.Split(' ').Select(byte.Parse).ToArray();

            var wordInput = System.Console.ReadLine();

            var maxHeight = 0;
            foreach (var c in wordInput)
            {
                var height = heights[alphabet.IndexOf(c)];
                if (height > maxHeight)
                    maxHeight = height;
            }

            System.Console.WriteLine(maxHeight * wordInput.Length);
        }
    }
}
