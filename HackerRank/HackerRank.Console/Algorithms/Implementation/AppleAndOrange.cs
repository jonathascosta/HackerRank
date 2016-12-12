using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Console.Algorithms.Implementation
{
    public class AppleAndOrange : IChallengeSolver
    {
        public void Solve(params string[] args)
        {
            var inputST = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var s = inputST[0];
            var t = inputST[1];

            var inputAB = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var a = inputAB[0];
            var b = inputAB[1];

            // no use for m and n
            System.Console.ReadLine();

            var applesDistances = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var orangesDistances = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var applesOnHouse = 0;
            foreach (var apple in applesDistances)
            {
                if (a + apple >= s && a + apple <= t)
                    applesOnHouse++;
            }

            var orangesOnHouse = 0;
            foreach (var orange in orangesDistances)
            {
                if (b + orange >= s && b + orange <= t)
                    orangesOnHouse++;
            }

            System.Console.WriteLine(applesOnHouse);
            System.Console.WriteLine(orangesOnHouse);
        }
    }
}
