using System;
using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace FotballScore.Tests
{
    public class ScoreServiceTests
    {
        [Fact]
        public void PrintInitialFootballScores()
        {
            //Arrange
            Dictionary<string, int[]> _initialData = new Dictionary<string, int[]>();
            _initialData.Add("Test Key", new int[] { 0, 1 });

            //Act
            var expectedKey = "Test Key";
            var expectedIncomeType = typeof(Dictionary<string, int[]>);

            //Assert
            Assert.Equal(expectedKey, _initialData.Keys.First());
            Assert.IsType(expectedIncomeType, _initialData);
            Assert.NotNull(_initialData.Keys.First());
            Assert.NotNull(_initialData.Values.First()); 

        }

        [Fact]
        public void SortInitialFootballScoresByDesc_Check_Key_Length_and_Sum()
        {
            //Arrange
            Dictionary<string, int[]> _initialData = new Dictionary<string, int[]>();
            _initialData.Add("Test Key", new int[] { 0, 1 });

            //Act
            var expectedValSum = new int[] { 0, 1 }.Sum();
            var expectedValLength = new int[] { 0, 1 }.Length;

            //Assert
            Assert.Equal(expectedValSum, _initialData.Values.First().Sum());
            Assert.Equal(expectedValLength, _initialData.Values.First().Length);

        }

        [Fact]
        public void SortInitialFootballScoresByDesc_Check_is_Sorting_ByDesc()
        {
            //Arrange
            Dictionary<string, int[]> _initialData = new Dictionary<string, int[]>();
            _initialData.Add("Test Key1", new int[] { 0, 1 });
            _initialData.Add("Test Key2", new int[] { 0, 2 });
            _initialData.Add("Test Key3", new int[] { 1, 3 });

            //Act
            var expectedValsSum = new int[] { 4, 2, 1 };
            var actalResult = new int[expectedValsSum.Length];
            var actualInitialData = _initialData.ToList();
            actualInitialData.Sort(
                (firstPair, nextPair) => firstPair.Value.Sum().CompareTo(nextPair.Value.Sum()));
            actualInitialData.Reverse();
            int i = 0;

            //Assert
            foreach (var item in actualInitialData)
            {
                Assert.Equal(item.Value.Sum(), expectedValsSum[i]);
                i++;
            }
            
        }
    }
}
