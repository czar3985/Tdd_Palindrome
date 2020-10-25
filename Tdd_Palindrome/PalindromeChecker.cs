namespace Tdd_Palindrome
{
    public class PalindromeChecker
    {
        public bool IsPalindrome(string word)
        {           
            for (var index = 0; index < word.Length/2; index++)
            {
                if (word[index] == word[word.Length - 1 - index])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
