using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballScore
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int[]> initialData = new Dictionary<string, int[]>();
            initialData.Add("Mexico - Canada", new int[] { 0, 5 });
            initialData.Add("Spain - Brazil", new int[] { 10, 2 });
            initialData.Add("Germany - France", new int[] { 2, 2 });
            initialData.Add("Uruguay - Italy", new int[] { 6, 6 });
            initialData.Add("Argentina - Australia", new int[] { 3, 1 });

            Console.WriteLine("Start Game: ");

            foreach (var item in initialData)
            {
                Console.WriteLine($"{item.Key} {item.Value[0]} {item.Value[1]}");
            }

            var teamsSumScores = initialData.ToList();
            teamsSumScores.Sort((firstPair, nextPair) => firstPair.Value.Sum().CompareTo(nextPair.Value.Sum()));
            teamsSumScores.Reverse();

            Console.WriteLine();
            Console.WriteLine("Result: ");
            foreach (var item in teamsSumScores)
            {
                string homeTeam = $"{item.Key.Substring(0, item.Key.LastIndexOf('-'))} {item.Value[0]}";
                string awayTeam = $"{item.Key.Substring(item.Key.IndexOf('-') + 1)} {item.Value[1]}";
                Console.WriteLine(homeTeam + " - " + awayTeam);
            }
        }
    }
}
