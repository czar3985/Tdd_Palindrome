using FluentAssertions;
using Xunit;

namespace Tdd_Palindrome.Tests
{
    public class PalindromeCheckerTests
    {
        [Theory]
        [InlineData("a")]
        [InlineData("")]
        public void Given_one_character_or_empty_string_then_palindrome(string word)
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(word);
            result.Should().BeTrue();
        }
    }
}
