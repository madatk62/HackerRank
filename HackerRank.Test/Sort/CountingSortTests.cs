using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Sort.Tests
{
    public class CountingSortTests
    {
        [Fact]
        public void TestCountingSort1_WithSmallArray()
        {
            var arr = new List<int> { 1, 4, 1, 2, 7, 5, 2 };
            var expected = new List<int> { 0, 2, 2, 0, 1, 1, 0, 1 };
            var result = CountingSort.CountingSort1(arr);
            Assert.Equal(expected, result.GetRange(0, 8));
        }

        [Fact]
        public void TestCountingSort1_WithLargeArray()
        {
            var arr = new List<int>(new int[100000]);
            var random = new Random();
            for (int i = 0; i < arr.Count; i++)
            {
                arr[i] = random.Next(0, 101);
            }

            var result = CountingSort.CountingSort1(arr);
            Assert.Equal(100000, result.Sum());
        }

        [Fact]
        public void TestCountingSort1_WithMaxValues()
        {
            var arr = new List<int>(Enumerable.Repeat(100, 100000));
            var expected = new List<int>(new int[100]);
            expected.Add(100000);

            var result = CountingSort.CountingSort1(arr);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCountingSort1_WithMinValues()
        {
            var arr = new List<int>(Enumerable.Repeat(0, 100000));
            var expected = new List<int> { 100000 };
            expected.AddRange(new int[100]);

            var result = CountingSort.CountingSort1(arr);
            Assert.Equal(expected, result);
        }
    }
}
