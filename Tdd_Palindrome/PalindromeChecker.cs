namespace Tdd_Palindrome
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {
            if ((word.Length == 0) || (word.Length == 1))
            {
                return true;
            }
            
            if (word.Length == 2 && word[0] == word[1])
            {
                return true;
            }

            return false;
        }
    }
}
