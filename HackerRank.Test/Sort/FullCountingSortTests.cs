using HackerRank.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Test.Sort
{
    public class FullCountingSortTests
    {
        [Fact]
        public void Test_BasicInput()
        {
            var input = new List<List<string>>
        {
            new List<string> { "4", "that" },
            new List<string> { "3", "be" },
            new List<string> { "0", "to" },
            new List<string> { "1", "be" },
            new List<string> { "5", "question" },
            new List<string> { "1", "or" },
            new List<string> { "2", "not" },
            new List<string> { "4", "is" },
            new List<string> { "2", "to" },
            new List<string> { "4", "the" }
        };

            string expectedOutput = "- - to be or not to be is the question";
            Assert.Equal(expectedOutput, CountingSort.FullCountingSort(input));
        }

        [Fact]
        public void Test_MinMaxXValues()
        {
            var input = new List<List<string>>
        {
            new List<string> { "0", "zero" },
            new List<string> { "99", "ninetyNine" }
        };

            string expectedOutput = "- ninetyNine";
            Assert.Equal(expectedOutput, CountingSort.FullCountingSort(input));
        }

        [Fact]
        public void Test_SameXValues()
        {
            var input = new List<List<string>>
        {
            new List<string> { "5", "apple" },
            new List<string> { "5", "banana" },
            new List<string> { "5", "cherry" },
            new List<string> { "5", "date" }
        };

            string expectedOutput = "- - cherry date";
            Assert.Equal(expectedOutput, CountingSort.FullCountingSort(input));
        }

        [Fact]
        public void Test_SingleElement()
        {
            var input = new List<List<string>> { new List<string> { "0", "one" } };
            string expectedOutput = "-";
            Assert.Equal(expectedOutput, CountingSort.FullCountingSort(input));
        }

        [Fact]
        public void Test_EmptyString()
        {
            var input = new List<List<string>>
        {
            new List<string> { "1", "" },
            new List<string> { "2", "word" }
        };

            string expectedOutput = "- word";
            Assert.Equal(expectedOutput, CountingSort.FullCountingSort(input));
        }

        [Fact]
        public void Test_LargeInput()
        {
            var input = new List<List<string>>();
            for (int i = 0; i < 1000; i++)
            {
                input.Add(new List<string> { (i % 100).ToString(), $"str{i}" });
            }

            // Kết quả mong đợi: 500 dấu "-" đầu, sau đó là các chuỗi từ str500 đến str999 theo thứ tự.
            string expectedOutput = string.Join(" ", Enumerable.Repeat("-", 500).Concat(Enumerable.Range(500, 500).Select(i => $"str{i}")));

            Assert.Equal(expectedOutput, CountingSort.FullCountingSort(input));
        }
    }
}
