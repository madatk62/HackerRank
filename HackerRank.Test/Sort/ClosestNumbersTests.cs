using HackerRank.Sort;

namespace HackerRank.Test.Sort
{
    public class ClosestNumbersTests
    {
        [Fact]
        public void TestExample1()
        {
            // Arrange
            List<int> input = new List<int> { -20, -3916237, -357920, -3620601, 7374819, -7330761, 30, 6246457, -6461594, 266854 };
            List<int> expected = new List<int> { -20, 30 };

            // Act
            List<int> result = ClosestNumbers.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestExample2()
        {
            // Arrange
            List<int> input = new List<int> { 5, 4, 3, 2 };
            List<int> expected = new List<int> { 2, 3, 3, 4, 4, 5 };

            // Act
            List<int> result = ClosestNumbers.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestMinimumSizeArray()
        {
            // Arrange
            List<int> input = new List<int> { 1, 3 };
            List<int> expected = new List<int> { 1, 3 };

            // Act
            List<int> result = ClosestNumbers.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestNegativeNumbers()
        {
            // Arrange
            List<int> input = new List<int> { -5, -4, -3, -1 };
            List<int> expected = new List<int> { -5, -4, -4, -3};

            // Act
            List<int> result = ClosestNumbers.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestLargeDifference()
        {
            // Arrange
            List<int> input = new List<int> { 1000000000, -1000000000, 0 };
            List<int> expected = new List<int> { -1000000000, 0, 0, 1000000000 };

            // Act
            List<int> result = ClosestNumbers.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestDuplicateNumbers()
        {
            // Arrange
            List<int> input = new List<int> { 2, 2, 3, 3 };
            List<int> expected = new List<int> { 2, 2, 3, 3 };

            // Act
            List<int> result = ClosestNumbers.Handle(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
