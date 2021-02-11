using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballCupScoreService
{
    /// <summary>
    /// Service  ScoreService
    /// Contains all methods for sorting and printing Football Cup Scores.
    /// </summary>
    public class ScoreService
    {
        private readonly Dictionary<string, int[]> _initialData;

        public ScoreService(Dictionary<string, int[]> initialData)
        {
            _initialData = initialData;
        }

        /// <summary>
        /// Sorting initial football scores by descending
        /// </summary>
        /// <returns>List of KeyValuePairs</returns>
        private List<KeyValuePair<string, int[]>> SortInitialFootballScoresByDesc()
        {
            var teamsSumScores = _initialData.ToList();
            teamsSumScores.Sort(
                (firstPair, nextPair) => firstPair.Value.Sum().CompareTo(nextPair.Value.Sum()));
            teamsSumScores.Reverse();

            return teamsSumScores;
        }

        /// <summary>
        /// Printing initial football scores
        /// </summary>
        public void PrintInitialFootballScores()
        {
            if (_initialData.Count > 0)
            {
                Console.WriteLine("Start Game: ");
                foreach (var item in _initialData)
                {
                    Console.WriteLine($"{item.Key} {item.Value[0]} {item.Value[1]}");
                }
            }
            else
            {
                Console.WriteLine("Nothing to print, please add initial data");
            }
           
        }

        /// <summary>
        /// Printing sorted football scores by descending
        /// </summary>
        public void PrintSortedFootballScores()
        {
            var sortedResults = SortInitialFootballScoresByDesc();

            Console.WriteLine();
            Console.WriteLine("Result: ");

            foreach (var item in sortedResults)
            {
                string homeTeam = $"{item.Key.Substring(0, item.Key.LastIndexOf('-'))} {item.Value[0]}";
                string awayTeam = $"{item.Key.Substring(item.Key.IndexOf('-') + 1)} {item.Value[1]}";
                Console.WriteLine(homeTeam + " - " + awayTeam);
            }
        }
    }
}
