using HackerRank.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Test.Sort
{
    public class QuickSort1Test
    {
        [Fact]
        public void QuickSort1Test_CorrectlySortedArray()
        {
            var input = new List<int> { 4, 5, 3, 7, 2 };
            var expected = new List<int> { 3, 2, 4, 5, 7 };
            var actual = QuickSort.QuickSort1(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void QuickSort1Test_SortedEmptyArray()
        {
            var input = new List<int>();
            var expected = new List<int>();
            var actual = QuickSort.QuickSort1(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void QuickSort1Test_SortedArray()
        {
            var input = new List<int> { 1, 2, 3, 4, 5 };
            var expected = new List<int> { 1, 2, 3, 4, 5 };
            var actual = QuickSort.QuickSort1(input);
            Assert.Equal(expected, actual);
        }
        [Fact] 
        public void QuickSort1Test_SortedArrayWithDuplicates()
        {
            var input = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            var expected = new List<int> { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            var actual = QuickSort.QuickSort1(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void QuickSort1Test_SortedReserverdArray()
        {
            var input = new List<int> { 5, 4, 3, 2, 1 };
            var expected = new List<int> { 4, 3, 2, 1, 5 };
            var actual = QuickSort.QuickSort1(input);
            Assert.Equal(expected, actual);
        }
    }
}
