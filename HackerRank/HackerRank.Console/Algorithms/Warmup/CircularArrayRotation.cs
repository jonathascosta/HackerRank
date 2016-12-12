using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Console.Algorithms.Warmup
{
    public class CircularArrayRotation : IChallengeSolver
    {
        public void Solve(params string[] args)
        {
            var input = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var n = input[0];
            var k = input[1] % n;
            var q = input[2];
            var a = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < q; i++)
            {
                var m = int.Parse(System.Console.ReadLine());
                System.Console.WriteLine(a[(m + k)%n]);
            }
        }
    }
}
