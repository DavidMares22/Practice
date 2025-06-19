using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class LongestEvenWord
    {

        public static string FindLongestEvenWord(string input)
        {
            var wordArr = input.Split(" ");
            var longestSoFar = string.Empty;

            foreach (var word in wordArr)
            {
                if(word.Length > longestSoFar.Length && word.Length % 2 == 0)
                {

                longestSoFar = word;
                }
            }

            return string.IsNullOrEmpty(longestSoFar)? "00" : longestSoFar;
        }

        public static string FindLongestEvenWord2(string input)
        {
            var longestEvenWord = input
                .Split(' ')
                .Where(word => word.Length % 2 == 0)
                .OrderByDescending(word => word.Length)
                .FirstOrDefault();

            return string.IsNullOrEmpty(longestEvenWord) ? "00" : longestEvenWord;
        }

    }
}
