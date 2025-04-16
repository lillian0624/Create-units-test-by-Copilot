using System.Numbers;
using Xunit;

namespace Numbers.Tests
{
    public class PrimeServiceTest
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTest()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void IsPrime_InputIs1_ReturnsFalse()
        {
            // Arrange
            int candidate = 1;

            // Act
            bool result = _primeService.IsPrime(candidate);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void IsPrime_InputIs2_ReturnsTrue()
        {
            // Arrange
            int candidate = 2;

            // Act
            bool result = _primeService.IsPrime(candidate);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPrime_InputIs3_ReturnsTrue()
        {
            // Arrange
            int candidate = 3;

            // Act
            bool result = _primeService.IsPrime(candidate);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void IsPrime_InputIs4_ReturnsFalse()
        {
            // Arrange
            int candidate = 4;

            // Act
            bool result = _primeService.IsPrime(candidate);

            // Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        public void IsPrime_ValidInputs_ReturnsExpectedResult(int candidate, bool expectedResult)
        {
            // Act
            bool result = _primeService.IsPrime(candidate);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}// filepath: /Users/yangli/Downloads/SampleApps/APL2007M4PrimeService/Numbers/PrimeServiceTest.cs
using Xunit;

namespace System.Numbers.UnitTests
{
    public class PrimeServiceTests
    {
        private readonly PrimeService _primeService;

        public PrimeServiceTests()
        {
            _primeService = new PrimeService();
        }

        [Theory]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(1, false)]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(11, true)]
        [InlineData(13, true)]
        [InlineData(15, false)]
        [InlineData(17, true)]
        [InlineData(20, false)]
        [InlineData(25, false)]
        public void IsPrime_ShouldReturnExpectedResult(int candidate, bool expected)
        {
            // Act
            var result = _primeService.IsPrime(candidate);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}