using System;
using System.Diagnostics;
using System.Linq;
using Algorithms.Algorithms;
using Algorithms.BinaryTree;
using Algorithms.Singleton;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = $"The two castaways, John Ferrier and the little girl who had shared his fortunes and had been adopted as his daughter, accompanied the Mormons to the end of their great pilgrimage. Little Lucy Ferrier was borne along pleasantly enough in Elder Stangerson’s waggon, a retreat which she shared with the Mormon’s three wives and with his son, a headstrong forward boy of twelve. Having rallied, with the elasticity of childhood, from the shock caused by her mother’s death, she soon became a pet with the women, and reconciled herself to this new life in her moving canvas-covered home. In the meantime Ferrier having recovered from his privations, distinguished himself as a useful guide and an indefatigable hunter. So rapidly did he gain the esteem of his new companions, that when they reached the end of their wanderings, it was unanimously agreed that he should be provided with as large and as fertile a tract of land as any of the settlers, with the exception of Young himself, and of Stangerson, Kemball, Johnston, and";
        

            Miscellaneous miscellaneous = new Miscellaneous();

            #region Practicing Memory
            int[] numbersList = { 1, 3, 4, 2, 1 };
            var duplicated = numbersList.GroupBy(n => n).Any(key => key.Count() > 1);

            var cleanText = text.Replace(",", "");
            string[] words = cleanText.Split();

            var groupedWords = words.GroupBy(word => word.ToLower())
                                    .Select(x => new { Word= x.Key, Count = x.Count()});

            var dictionaryWords = words.GroupBy(word => word.ToLower())
                                    .ToDictionary(x => x.Key, y=> y.Count());

            char[] cha = { 'w', 'o', 'r', 'l', 'd' };

            string chajoin = string.Join("", cha);

             var rev = string.Join("",cha.Reverse());

            char[] fff = { 'J', 'a', 'n', 'e', ' ', 'D', 'o', 'e' };

            string rrr = string.Join("", fff) + string.Join("", fff.Reverse());

            int[] bizzbuzzList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            var bizzuzzMesaages = bizzbuzzList.Select(x => miscellaneous.FizzBuzzMessage(x));

          



            string t =null;

            #endregion

            #region Word count in a Text
            /*
            //var result1 = miscellaneous.CountWordsRepetitionLoop(text, 1);
            //var result2 = miscellaneous.CountWordsRepetition(text,1);
            */
            #endregion

            #region Duplicated Values
            int[] nums = { 1, 3, 4, 2, 1 };
            int[] nums2 = { 1, 3, 4, 2, 5 };        


            var result3 = miscellaneous.CheckDuplicatedValues(nums);
            var result4 = miscellaneous.CheckDuplicatedValues(nums2);

            var result5 = miscellaneous.CheckDuplicatedValuesLoop(nums);
            var result6 = miscellaneous.CheckDuplicatedValuesLoop(nums2);
            #endregion

            #region Singleton
            SingletonClass singletonClass = SingletonClass.Instance;
            SingletonClass singletonClass2 = SingletonClass.Instance;
            SingletonClass singletonClass3 = SingletonClass.Instance;
            #endregion

            #region Concatenate Chars
            char[] chars = { 'J', 'a', 'n', 'e', ' ', 'D', 'o', 'e' };
            string result = miscellaneous.ConcatChars(chars);
            string results = miscellaneous.ConcatCharsLoop(chars);
            #endregion

            #region Binary Tree
            /*
            //Using the Tree structure
            Tree tree = new Tree();
  
            tree.Add(4);
            tree.Add(2);
            tree.Add(7);
            tree.Add(1);
            tree.Add(3);
            tree.Add(6);
            tree.Add(9);

            var nodeValues = tree.NodesInOrder;
            tree.InvertTree(tree.Root);
           
            var newNodesValues = tree.NodesInOrder;
            */
            #endregion

            #region Reverse Array
            var watch = new Stopwatch();
            var watchNoLoop = new Stopwatch();

            char[] chars2 = { 'J', 'a', 'n', 'e', ' ', 'D', 'o', 'e' };
            watch.Start();
            var reversed = miscellaneous.ReverseArray(chars2);
            watch.Stop();
            long noLoop = watch.ElapsedMilliseconds;
            watchNoLoop.Start();
            var reversed2 = miscellaneous.ReverseArrayLoop(chars2);
            watchNoLoop.Stop();
            long loop = watchNoLoop.ElapsedMilliseconds;

            #endregion

            #region Reverse Concatenated Array
            char[] chars3 = { 'J', 'a', 'n', 'e', ' ', 'D', 'o', 'e' };

            var reverseConcatenated = miscellaneous.ReverseConcatenatedArray(chars3);
            #endregion

            #region First No repeated Char

            string xampleWord = "aaabbbdddefefef";
            char character = miscellaneous.FirstNonRepeatingChar(xampleWord);
            #endregion

            #region Min and Max number
            int[] numbers = { 54, 32, 20, 80, 25, 7, 47 };
            dynamic minMaxObj = miscellaneous.MinAndMaxNumber(numbers);
            dynamic minMaxObjLoop = miscellaneous.MinAndMaxNumberLoop(numbers);
            //Console.WriteLine("Without Loop");
            //Console.WriteLine($"Min: {minMaxObj.Min} Max: {minMaxObj.Max}");
            //Console.WriteLine($"With loop");
            //Console.WriteLine($"Min: {minMaxObjLoop.Min} Max: {minMaxObjLoop.Max}");


            #endregion

            #region FizzBuzz
            //miscellaneous.FizzBuzz(100);
            #endregion

            #region Palindrome
            string inputText = Console.ReadLine();
            Console.WriteLine(miscellaneous.IsPalindrome(inputText) == true ? "IsPalimdrome" : "Not Palindrome");
            #endregion;
            Console.ReadKey();

        }
    }
}
