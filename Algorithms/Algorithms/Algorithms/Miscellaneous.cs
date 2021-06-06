using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms
{
    public class Miscellaneous
    {
        /// <summary>
        /// Given a text, return the words that repeates more than the specified in the parameter using loop.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="overRepetitionCount"></param>
        /// <returns><see cref="List{T}>"/></returns>
        public object CountWordsRepetitionLoop(string text, int overRepetitionCount = 1)
        {
            string cleanedText = text.Replace(",", "");
            var words = cleanedText.Split(" ");
            Dictionary<string, int> dictionaryWords = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (dictionaryWords.ContainsKey(word))
                    dictionaryWords[word] = dictionaryWords[word] + 1;
                else
                    dictionaryWords.Add(word, 1);
            }

            var duplicatedWords = dictionaryWords
                .Where(a => a.Value > 1)
                .Select(x => new { Word = x.Key, Count = x.Value })
                .ToList();
            return duplicatedWords;
        }

        /// <summary>
        /// Given a text, return the words that repeates more than the specified in the parameter without using loop.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="overRepetitionCount"></param>
        /// <returns><see cref="List{T}>"/></returns>
        public object CountWordsRepetition(string text, int overRepetitionCount = 0)
        {
            string cleanedText = text.Replace(",", "");
            var words = cleanedText.Split(" ");

            //To return an anonymous list
            var query = words.GroupBy(word => word)
              .Where(g => g.Count() > overRepetitionCount)
              .Select(x => new { Word = x.Key, Count = x.Count() })
              .ToList();

            //To return a Dictionary
            var query2 = words.GroupBy(word => word)
              .Where(g => g.Count() > overRepetitionCount)
              .ToDictionary(x => x.Key, y => y.Count());
            return query;
        }

        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct. 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckDuplicatedValues(int[] nums)
        {
            bool areDuplicated = nums.GroupBy(n => n).Any(x => x.Count() > 1);
            return areDuplicated;
        }

        /// <summary>
        /// Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.
        /// Using Loops
        /// </summary>
        /// <param name="nums"></param>
        /// <returns><see cref="bool"/></returns>
        public bool CheckDuplicatedValuesLoop(int[] nums)
        {
            Dictionary<int, int> recordedNums = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];
                if (recordedNums.ContainsKey(currentNum))
                    return true;
                recordedNums.Add(currentNum,1);
            }
            return false;
        }
    }
}
