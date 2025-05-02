using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ATMDenomination.Tests
{
    public class ATMDenominationTests
    {
        [Theory]
        [InlineData(30, new[] { 10, 50, 100 }, 1)] // 3 x 10 EUR
        [InlineData(50, new[] { 10, 50, 100 }, 2)] // 1 x 50 EUR or 5 x 10 EUR
        [InlineData(100, new[] { 10, 50, 100 }, 4)] // 1 x 100 EUR, 2 x 50 EUR, 1 x 50 EUR + 5 x 10 EUR, or 10 x 10 EUR
        public void FindCombinations_ShouldReturnCorrectNumberOfCombinations(int amount, int[] denominations, int expectedCombinations)
        {
            // Arrange
            var calculator = new Program();

            // Act
            var combinations = calculator.FindCombinations(amount, denominations);

            // Assert
            Assert.Equal(expectedCombinations, combinations.Count);
        }

        [Fact]
        public void FindCombinations_ShouldReturnValidCombinations()
        {
            // Arrange
            var calculator = new Program();
            int amount = 100;
            int[] denominations = { 10, 50, 100 };

            // Act
            var combinations = calculator.FindCombinations(amount, denominations);

            // Assert
            foreach (var combination in combinations)
            {
                Assert.Equal(amount, combination.Sum());
                Assert.True(combination.All(x => denominations.Contains(x)));
            }
        }

        [Fact]
        public void FindCombinations_ShouldHandleZeroAmount()
        {
            // Arrange
            var calculator = new Program();
            int amount = 0;
            int[] denominations = { 10, 50, 100 };

            // Act
            var combinations = calculator.FindCombinations(amount, denominations);

            // Assert
            Assert.Single(combinations);
            Assert.Empty(combinations[0]);
        }

        [Fact]
        public void FindCombinations_ShouldHandleImpossibleAmount()
        {
            // Arrange
            var calculator = new Program();
            int amount = 35; // Cannot be made with given denominations
            int[] denominations = { 10, 50, 100 };

            // Act
            var combinations = calculator.FindCombinations(amount, denominations);

            // Assert
            Assert.Empty(combinations);
        }
    }
} 