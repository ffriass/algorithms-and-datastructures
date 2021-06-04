using System;
using Algorithms.BinaryTree;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

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
