using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Console.Algorithms.Implementation
{
    public class MiniMaxSum : IChallengeSolver
    {
        public void Solve(params string[] args)
        {
            var input = System.Console.ReadLine();
            var numbers = input.Split(' ').Select(long.Parse).OrderBy(n => n);
            var min = numbers.Take(4).Sum();
            var max = numbers.Reverse().Take(4).Sum();
            System.Console.WriteLine($"{min} {max}");
        }
    }
}
