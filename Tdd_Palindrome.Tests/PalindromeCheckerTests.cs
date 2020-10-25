using FluentAssertions;
using Xunit;

namespace Tdd_Palindrome.Tests
{
    public class PalindromeCheckerTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        [InlineData("aa")]
        public void Given_a_palindrome_then_IsPalindrome_returns_true(string word)
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(word);
            result.Should().BeTrue();
        }
    }
}
