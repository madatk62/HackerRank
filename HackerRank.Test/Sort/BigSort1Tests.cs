using HackerRank.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Test.Sort
{
    public class BigSort1Tests
    {
        [Fact]
        public void TestBasicSorting()
        {
            List<string> input = new List<string>() { "1", "3", "10", "5" };
            List<string> expected = new List<string>() { "1", "3", "5", "10" };
            List<string> result = BigSorting.BigSort1(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDuplicateNumbers()
        {
            List<string> input = new List<string>() { "3", "1", "3", "10" };
            List<string> expected = new List<string>() { "1", "3", "3", "10" };
            List<string> result = BigSorting.BigSort1(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLargeNumbers()
        {
            List<string> input = new List<string>() { "31415926535897932384626433832795", "1", "3", "10" };
            List<string> expected = new List<string>() { "1", "3", "10", "31415926535897932384626433832795" };
            List<string> result = BigSorting.BigSort1(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestSingleElement()
        {
            List<string> input = new List<string>() { "12345" };
            List<string> expected = new List<string>() { "12345" };
            List<string> result = BigSorting.BigSort1(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestEmptyArray()
        {
            List<string> input = new List<string>();
            List<string> expected = new List<string>();
            List<string> result = BigSorting.BigSort1(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLeadingZeros()
        {
            // Arrange
            List<string> input = new List<string>() { "01", "2", "03", "0010", "000" };
            List<string> expected = new List<string>() { "000", "01", "2", "03", "0010" }; // "000" = 0, "01" = 1, "2" = 2, "03" = 3, "0010" = 10

            // Act
            List<string> result = BigSorting.BigSort1(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
