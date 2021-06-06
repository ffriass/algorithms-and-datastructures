using System;
using Algorithms.Algorithms;
using Algorithms.BinaryTree;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = $"The two castaways, John Ferrier and the little girl who had shared his fortunes and had been adopted as his daughter, accompanied the Mormons to the end of their great pilgrimage. Little Lucy Ferrier was borne along pleasantly enough in Elder Stangerson’s waggon, a retreat which she shared with the Mormon’s three wives and with his son, a headstrong forward boy of twelve. Having rallied, with the elasticity of childhood, from the shock caused by her mother’s death, she soon became a pet with the women, and reconciled herself to this new life in her moving canvas-covered home. In the meantime Ferrier having recovered from his privations, distinguished himself as a useful guide and an indefatigable hunter. So rapidly did he gain the esteem of his new companions, that when they reached the end of their wanderings, it was unanimously agreed that he should be provided with as large and as fertile a tract of land as any of the settlers, with the exception of Young himself, and of Stangerson, Kemball, Johnston, and";

            Miscellaneous miscellaneous = new Miscellaneous();
            //var result1 = miscellaneous.CountWordsRepetitionLoop(text, 1);
            //var result2 = miscellaneous.CountWordsRepetition(text,1);

            int[] nums = { 1, 3, 4, 2, 1 };
            int[] nums2 = { 1, 3, 4, 2, 5 };

            var result3 = miscellaneous.CheckDuplicatedValues(nums);
            var result4 = miscellaneous.CheckDuplicatedValues(nums2);

            var result5 = miscellaneous.CheckDuplicatedValuesLoop(nums);
            var result6 = miscellaneous.CheckDuplicatedValuesLoop(nums2);


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
            Console.ReadKey();

        }
    }
}
