using System;
using System.Collections.Generic;
using System.Linq;
using FootballCupScoreService;

namespace FootballScore
{
    class Program
    {
        static void Main(string[] args)
        {

            var initialData = new Dictionary<string, int[]>();
            initialData.Add("Mexico - Canada", new int[] { 0, 5 });
            initialData.Add("Spain - Brazil", new int[] { 10, 2 });
            initialData.Add("Germany - France", new int[] { 2, 2 });
            initialData.Add("Uruguay - Italy", new int[] { 6, 6 });
            initialData.Add("Argentina - Australia", new int[] { 3, 1 });

            var scoreService = new ScoreService(initialData);
            scoreService.PrintInitialFootballScores();
            scoreService.PrintSortedFootballScores();
        }
    }
}
