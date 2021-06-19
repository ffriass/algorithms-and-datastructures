using Algorithms.BinaryTree;
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
                recordedNums.Add(currentNum, 1);
            }
            return false;
        }

        /// <summary>
        /// Function that takes an array or list of chars, and returns a concatenated string for example:
        /// Input : ['J', 'a', 'n', 'e', ' ', 'D', 'o', 'e'] Output : Jane Doe
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public string ConcatChars(char[] chars)
        {
            string word = string.Join("", chars);
            return word;
        }

        /// <summary>
        /// Function that takes an array or list of chars, and returns a concatenated string using loop. for example:
        /// Input : ['J', 'a', 'n', 'e', ' ', 'D', 'o', 'e'] Output : Jane Doe
        /// </summary>
        /// <param name="chars"></param>
        /// <returns></returns>
        public string ConcatCharsLoop(char[] chars)
        {
            string word = "";
            foreach (char c in chars)
                word += c;
            return word;
        }

        /// <summary>
        /// Reverses an array of char’s Input : ['J', 'a', 'n', 'e', ' ', 'D', 'o', 'e'] 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public char[] ReverseArray(char[] elements)
        {
            var result = elements.Reverse();
            return result.ToArray();
        }

        /// <summary>
        /// Reverses an array of char’s using loop. Input : ['J', 'a', 'n', 'e', ' ', 'D', 'o', 'e'] 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public char[] ReverseArrayLoop(char[] elements)
        {
            char[] reversedArray = new char[elements.Length];
            int limit = elements.Length - 1;
            for (int i = 0; i < elements.Length; i++)
            {
                reversedArray[i] = elements[limit - i];
            }

            return reversedArray;
        }

        /// <summary>
        /// Reverses an array of char’s using loop. Input : ['J', 'a', 'n', 'e', ' ', 'D', 'o', 'e'] 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public string ReverseConcatenatedArray(char[] elements)
        {
            string result = ConcatChars(elements);
            result += ConcatChars(ReverseArrayLoop(elements));

            return result;
        }
        /// <summary>
        /// Find first non-repeating character using loop: For e.g. Input = aaabbbcdddefefef Output = c 
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public char FirstNonRepeatingCharLoop(string elements)
        {
            foreach (char c in elements)
            {
                if (elements.Where(x => x == c).Count() == 1)
                    return c;
            }
            return ' ';
        }

        /// <summary>
        /// Find first non-repeating character without loop: For e.g. Input = aaabbbcdddefefef Output = c 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public char FirstNonRepeatingChar(string text)
        {
            var groupedElements = text.GroupBy(c => c);
            var t = groupedElements.FirstOrDefault(x => x.Count() == 1);
            return t?.Key ?? ' ';
        }

        /// <summary>
        /// Find the min and max element in an array Input without loop: [54, 32, 20, 80, 25, 7, 47] Output : Min 7 Max 80 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public object MinAndMaxNumber(int[] numbers)
        {
            var result = new { Min = numbers.Min(), Max = numbers.Max() };
            return result;
        }

        /// <summary>
        /// Find the min and max element in an array Input without loop: [54, 32, 20, 80, 25, 7, 47] Output : Min 7 Max 80 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public object MinAndMaxNumberLoop(int[] numbers)
        {
            int[] orderedNumbers = numbers.OrderBy(n => n).ToArray();
            var result = new { Min = orderedNumbers[0], Max = orderedNumbers[orderedNumbers.Length - 1] };
            return result;
        }

        /// <summary>
        /// You have a collection of numbers 1 to 100
        ///I want you to cycle throw this collection and output the following:
        ///If the number is evenly divisible by 3, output the word "Fizz"
        ///If the number is evenly divisible by 5, output the word "Buzz"
        ///For each number that is evenly divisible by both 3 and 5, output the word "FizzBuzz"
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public void FizzBuzz(int[] numbers)
        {
            foreach (int num in numbers)
            {               
                Console.WriteLine(FizzBuzzMessage(num));
            }
        }

        /// <summary>
        /// You have a collection of numbers 1 to 100
        ///I want you to cycle throw this collection and output the following:
        ///If the number is evenly divisible by 3, output the word "Fizz"
        ///If the number is evenly divisible by 5, output the word "Buzz"
        ///For each number that is evenly divisible by both 3 and 5, output the word "FizzBuzz"
        ///Do it without an Array
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public void FizzBuzz(int maxNumber)
        {
            for (int num = 1; num <= maxNumber; num++)
            {
                Console.WriteLine(FizzBuzzMessage(num));
            }
        }

        bool IsDivisible(int number, int divisor)
        {
            return number == 0 ? false : (number % divisor == 0) ? true : false;
            if (number == 0)
                return false;
            else if (number % divisor == 0)
                return true;
            return false;
        }

        public string FizzBuzzMessage(int number)
        {          

           if (IsDivisible(number, 3) && IsDivisible(number, 5))
                return  "FizzBuzz";
            else if (IsDivisible(number, 3))
                return "Fizz";
            else if (IsDivisible(number, 5))
                return "Buzz";
            else
                return number.ToString();         
        }

        /// <summary>
        /// The user will input a string and we need to print “Palindrome” or “Not Palindrome” based on whether the input string is a palindrome or not. 
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPalindrome(string word)
        {
            int size = word.Length - 1;

            for (int i = 0; i <= size; i++)
            {
                if (word[i] != word[size - i])
                    return false;

                if (i >= (size - i))
                    break;
            }
            return true;
        }
    }
}
