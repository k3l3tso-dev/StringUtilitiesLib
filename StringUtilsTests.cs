using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilitiesLib;

namespace StringUtilitiesLib.Tests
{
    [TestClass]
    public class StringUtilsTests
    {
        [TestMethod]
        public void Reverse_NormalString_ReturnsReversedString()
        {
            // Arrange
            string input = "hello";
            string expected = "olleh";

            // Act
            string actual = StringUtils.Reverse(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Reverse_NullInput_ReturnsNull()
        {
            // Arrange
            string input = null;

            // Act
            string result = StringUtils.Reverse(input);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void IsPalindrome_ValidPalindrome_ReturnsTrue()
        {
            // Arrange
            string input = "A man, a plan, a canal, Panama!";

            // Act
            bool result = StringUtils.IsPalindrome(input);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsPalindrome_NotPalindrome_ReturnsFalse()
        {
            // Arrange
            string input = "Hello World";

            // Act
            bool result = StringUtils.IsPalindrome(input);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CountVowels_StringWithVowels_ReturnsCorrectCount()
        {
            // Arrange
            string input = "Hello World";
            int expected = 3; // e, o, o

            // Act
            int actual = StringUtils.CountVowels(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeTruncate_LongString_TruncatesWithEllipsis()
        {
            // Arrange
            string input = "This is a very long sentence.";
            int maxLength = 10;
            string expected = "This is a...";

            // Act
            string actual = StringUtils.SafeTruncate(input, maxLength);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SafeTruncate_ShortString_ReturnsOriginalString()
        {
            // Arrange
            string input = "Hi";
            int maxLength = 10;

            // Act
            string result = StringUtils.SafeTruncate(input, maxLength);

            // Assert
            Assert.AreEqual(input, result);
        }
    }
}