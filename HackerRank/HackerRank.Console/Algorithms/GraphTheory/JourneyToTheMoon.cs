using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Console.Algorithms.GraphTheory
{
    public class JourneyToTheMoon : IChallengeSolver
    {
        public void Solve(params string[] args)
        {
            var input = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var N = input[0];
            var I = input[1];
            var countries = new List<Country>();

            for (var i = 0; i < I; i++)
            {
                var astronauts = System.Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var foundCountries = countries.Where(c => c.Intersect(astronauts).Any()).ToArray();
                switch (foundCountries.Length)
                {
                    case 2:
                        countries[foundCountries[0].Index].AddRange(foundCountries[1]);
                        for (int j = foundCountries[1].Index + 1; j < countries.Count; j++)
                            countries[j].Index--;
                        countries.RemoveAt(foundCountries[1].Index);
                        break;
                    case 1:
                        if (!countries[foundCountries[0].Index].Contains(astronauts[0]))
                            countries[foundCountries[0].Index].Add(astronauts[0]);
                        if (!countries[foundCountries[0].Index].Contains(astronauts[1]))
                            countries[foundCountries[0].Index].Add(astronauts[1]);
                        break;
                    default:
                        countries.Add(new Country(countries.Count, astronauts));
                        break;
                }
            }
            
            var sum = 0L;
            for (int i = 0; i < countries.Count; i++)
                for (int j = i + 1; j < countries.Count; j++)
                    sum += countries[i].Count * countries[j].Count;

            var foundAstronauts = countries.Sum(c => c.Count);
            for (int i = foundAstronauts; i < N; i++)
                sum += i;
            
            System.Console.WriteLine(sum);
        }
    }

    public class Country : List<int>
    {
        public int Index { get; set; }

        public Country(int index, IEnumerable<int> astronauts) : base(astronauts)
        {
            Index = index;
        }
    }
}
