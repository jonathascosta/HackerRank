using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Console.Algorithms.Implementation;

namespace HackerRank.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IChallengeSolver challengeSolver;

            challengeSolver = new DesignerPdfViewer();

            challengeSolver.Solve();
        }
    }
}
