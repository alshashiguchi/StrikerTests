using Xunit;

namespace TestStriker.UnitTests
{
    public class UtilsTests
    {
        Utils _subject;

        public UtilsTests()
        {
            _subject = new Utils();
        }

        [Theory, CombinatorialData]
        [Trait("Category", "UnitTest")]
        public void SumTest([CombinatorialRange(0, 5)] int p1, [CombinatorialRange(0, 3, 2)] int p2)
        {
            // Arrange
            var expected = p1 + p2;

            // Act
            var result = _subject.Sum(p1, p2);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory, CombinatorialData]
        [Trait("Category", "UnitTest")]
        public void IncrementTest([CombinatorialRange(0, 5)] int p1)
        {
            // Arrange
            var expected = p1 + 1;

            // Act
            var result = _subject.Increment(p1);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        [Trait("Category", "UnitTest")]
        public void CompareTestFalse()
        {
            // Arrange
            var p1 = 1;
            var p2 = 2;

            // Act
            var result = _subject.Compare(p1, p2);

            // Assert
            Assert.False(result);
        }

        [Fact]
        [Trait("Category", "UnitTest")]
        public void CompareTestTrue()
        {
            // Arrange
            var p1 = 1;
            var p2 = 1;

            // Act
            var result = _subject.Compare(p1, p2);

            // Assert
            Assert.True(result);
        }

        [Fact]
        [Trait("Category", "UnitTest")]
        public void LastItemTest()
        {
            // Arrange
            var item = new List<int>
            {
                1,
                2,
                3
            };
            // Act
            var result = _subject.LastItem(item);

            // Assert
            Assert.Equal(item.Last(), result);
        }


        [Fact]
        [Trait("Category", "UnitTest")]
        public void ErrorLogEmpty()
        {
            // Act
            var result = Assert.Throws<ArgumentNullException>(() => _subject.Log(""));

            // Assert
            Assert.Equal("Value cannot be null. (Parameter 'Null value')", result.Message);
        }

        [Fact]
        [Trait("Category", "UnitTest")]
        public void ErrorLogNull()
        {
            // Act
            var result = Assert.Throws<ArgumentNullException>(() => _subject.Log(null));

            // Assert
            Assert.Equal("Value cannot be null. (Parameter 'Null value')", result.Message);
        }
    }
}