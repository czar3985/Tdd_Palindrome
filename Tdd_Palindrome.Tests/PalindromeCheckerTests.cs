using FluentAssertions;
using Xunit;

namespace Tdd_Palindrome.Tests
{
    public class PalindromeCheckerTests
    {
        [Fact]
        public void Given_one_character_then_palindrome()
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome("a");
            result.Should().BeTrue();
        }
    }
}
