using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Console.Algorithms.Warmup
{
    public class CompareTheTriplets : IChallengeSolver
    {
        public void Solve(params string[] args)
        {
            var a = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var b = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var A = 0;
            var B = 0;
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                    A++;
                if (a[i] < b[i])
                    B++;
            }
            System.Console.WriteLine($"{A} {B}");
        }
    }
}
