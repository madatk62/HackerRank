using HackerRank.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Test.Sort
{
    public class CountingSort2Test
    {
        [Fact]
        public void EmptyList_ReturnsEmptyList()
        {
            var input = new List<int>();
            var expected = new List<int>();
            var result = CountingSort.CountingSort2(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void SingleElement_ReturnsSortedList()
        {
            var input = new List<int> { 5 };
            var expected = new List<int> { 5 };
            var result = CountingSort.CountingSort2(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RepeatedElements_ReturnsSortedList()
        {
            var input = new List<int> { 3, 1, 3, 2, 1 };
            var expected = new List<int> { 1, 1, 2, 3, 3 };
            var result = CountingSort.CountingSort2(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AllZeros_ReturnsSortedList()
        {
            var input = new List<int> { 0, 0, 0 };
            var expected = new List<int> { 0, 0, 0 };
            var result = CountingSort.CountingSort2(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void AllNinetyNines_ReturnsSortedList()
        {
            var input = new List<int> { 99, 99, 99 };
            var expected = new List<int> { 99, 99, 99 };
            var result = CountingSort.CountingSort2(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void FullRange_ReturnsSortedList()
        {
            var input = new List<int> { 2, 0, 99, 1, 0, 98 };
            var expected = new List<int> { 0, 0, 1, 2, 98, 99 };
            var result = CountingSort.CountingSort2(input);
            Assert.Equal(expected, result);
        }

        
    }
}
