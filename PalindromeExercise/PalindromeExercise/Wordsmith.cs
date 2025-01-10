using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            string normalizedWord = word.ToLower().Replace(" ", "");
            
            char[] charArray = normalizedWord.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord = new string(charArray);
            
            return normalizedWord == reversedWord;
        }
    }
}