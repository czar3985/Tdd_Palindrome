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
        [InlineData("aba")]
        [InlineData("tacocat")]
        [InlineData("racecar")]
        [InlineData("hannah")]
        public void Given_a_palindrome_then_IsPalindrome_returns_true(string word)
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(word);
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData("ab")]
        [InlineData("palindrome")]
        [InlineData("xdfedx")]
        public void Given_a_nonpalindrome_then_IsPalindrome_returns_false(string word)
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(word);
            result.Should().BeFalse();
        }
    }
}
