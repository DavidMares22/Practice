using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class LongestEvenWord
    {
        // Helper method to remove punctuation from a word
        // StringBuilder is used for efficient string concatenation when iterating over each character,
        // as it avoids creating multiple intermediate string instances that would occur with string concatenation in a loop.
        private static string RemovePunctuation(string word)
        {
            var sb = new StringBuilder();
            foreach (var c in word)
            {
                if (char.IsLetterOrDigit(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }

        public static string FindLongestEvenWord(string input)
        {
            var wordArr = input.Split(" ");
            var longestSoFar = string.Empty;

            foreach (var word in wordArr)
            {
                var cleanWord = RemovePunctuation(word);
                if (cleanWord.Length > longestSoFar.Length && cleanWord.Length % 2 == 0)
                {
                    longestSoFar = cleanWord;
                }
            }

            return string.IsNullOrEmpty(longestSoFar) ? "00" : longestSoFar;
        }

        public static string FindLongestEvenWord2(string input)
        {
            var longestEvenWord = input
                .Split(' ')
                //If your input is "David. likes apples!", after splitting and applying .Select(RemovePunctuation), you get: ["David", "likes", "apples"].
                .Select(RemovePunctuation)
                .Where(word => word.Length % 2 == 0 && word.Length > 0)
                .OrderByDescending(word => word.Length)
                .FirstOrDefault();

            return string.IsNullOrEmpty(longestEvenWord) ? "00" : longestEvenWord;
        }
    }
}
